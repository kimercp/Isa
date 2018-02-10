using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ISAManagment
{
    public partial class frmAccounts : Form
    {
        // connection to database
        private OleDbConnection myConn;
        // account id number in database 
        private int accountID;

        // first constructor
        public frmAccounts()
        {
            InitializeComponent();
            mnuSaveChanges.Visible = false;
        }

        // second constructor
        public frmAccounts(Object[] customerDetails, Boolean isReadOnly)
        {
            InitializeComponent();
            // set all text fields just for read only
            if (isReadOnly)
            {
                // change the attribute of text field for read only 
                txtAccountId.Enabled = false;
                txtCustomerId.Enabled = false;
                txtProductId.Enabled = false;
                txtBalance.ReadOnly = true;
                txtAccrued.ReadOnly = true;
                txtActive.Enabled = false;
                rbOpenAccount.Enabled = false;
                rbCloseAccount.Enabled = false;
                dtpStartDateAccount.Enabled = false;

                // hide choose the product
                cmbChooseTheProduct.Visible = false;

                // change the color of font
                txtAccountId.ForeColor = Color.Black;
                txtCustomerId.ForeColor = Color.Black;
                txtProductId.ForeColor = Color.Black;
                txtBalance.ForeColor = Color.Black;
                txtAccrued.ForeColor = Color.Black;
                txtActive.ForeColor = Color.Black;
                // make the menu option unvisible
                mnuNew.Visible = false;
                mnuSaveChanges.Visible = false;
                grbProductDetails.Enabled = true;
                grbStatusAccount.Enabled = false;
            }
            else
            {
                // change the attribute of text field 
                txtAccountId.Enabled = false;
                txtCustomerId.Enabled = false;
                txtProductId.Enabled = false;
                txtBalance.Enabled = false;
                txtAccrued.Enabled = false;
                txtActive.Enabled = false;
                rbOpenAccount.Enabled = false;
                rbCloseAccount.Enabled = false;
                dtpStartDateAccount.Enabled = true;

                // show choose the product
                cmbChooseTheProduct.Visible = true;

                // make the menu option unvisible
                mnuNew.Visible = false;
                mnuMakeTransaction.Visible = false;
                grbProductDetails.Enabled = true;
                grbStatusAccount.Enabled = false;
            }

            // populate text fields with customer data
            accountID = Int32.Parse(customerDetails[0].ToString());
            txtAccountId.Text = customerDetails[0].ToString();
            txtCustomerId.Text = customerDetails[1].ToString();
            txtProductId.Text = customerDetails[2].ToString();
            txtBalance.Text = customerDetails[3].ToString();
            txtAccrued.Text = customerDetails[4].ToString();
            txtActive.Text = customerDetails[5].ToString();
            dtpStartDateAccount.Value = DateTime.Parse(customerDetails[6].ToString());
            string statusAccount = customerDetails[7].ToString();
            if (statusAccount == "open") rbOpenAccount.Checked = true;
            else rbCloseAccount.Checked = true;
            // make this text field not available to edit but visible for user
            txtAccountId.Enabled = false;            
        }

        // third constructor only with customer id
        public frmAccounts(int customerid)
        {
            InitializeComponent();            
            // populate text fields with customer data
            txtCustomerId.Text = customerid.ToString();
            // block the text field to prevent change of customer id
                //txtCustomerId.ReadOnly = true;
            txtCustomerId.Enabled = false;
            // make this text field not available to edit but visible for user
            txtAccountId.Enabled = false;
            txtBalance.Enabled = false;
            txtAccrued.Enabled = false;
            txtActive.Enabled = false;
            grbStatusAccount.Enabled = false;

            // hide option from menu

            mnuSaveChanges.Visible = false;
            mnuMakeTransaction.Visible = false;
            grbProductDetails.Enabled = true;
            txtProductId.ReadOnly = true;
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // load all open products to combo box to let user choose
        private void frmAccounts_Load(object sender, EventArgs e)
        {
            // create connection with database used the credentials written in connection string
            // "using" close and dispose the object to allow the resources to be used by other processes
            using (myConn = new OleDbConnection(dbConnection.dbConnect))
            {
                try
                {
                    string sql = @"SELECT prodid, name FROM product WHERE status = 'open'";
                    // open connection with database used the credentials written in connection string
                    myConn.Open();
                    OleDbCommand myCmd = new OleDbCommand(sql, myConn);
                    OleDbDataReader reader = myCmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    //dt.Columns.Add("prodid", typeof(string));
                    //dt.Columns.Add("name", typeof(string));
                    dt.Load(reader);
                    // value member is the product id
                    cmbChooseTheProduct.ValueMember = "prodid";
                    // that is a text which will display on combo box for user
                    cmbChooseTheProduct.DisplayMember = "name";
                    cmbChooseTheProduct.DataSource = dt;
                }
                // catch an error and holds all information in ex object
                catch (Exception ex)
                {
                    // display the message window to user informing him about error
                    MessageBox.Show("There was some errors. Try again please.");
                    Console.WriteLine(" ");
                    // display the content of error message as text in console
                    Console.WriteLine(ex.ToString());
                }
            }

            // create connection with database used the credentials written in connection string
            using (myConn = new OleDbConnection(dbConnection.dbConnect)) // "using" close and dispose the object to allow the resources to be used by other processes
            {
                try
                {
                    // open connection with database used the credentials written in connection string
                    myConn.Open();
                    // sql query send to database is written as string
                    // add parameters to sql query to update data only for only one record using specific customer id
                    string sql = @"SELECT title,firstname,lastname FROM customer WHERE custid = ?";
                    // create command using sql string and connection with database myConn
                    OleDbCommand myCmd = new OleDbCommand(sql, myConn);

                    // adding parameters to sql query
                    myCmd.Parameters.AddWithValue("custid", txtCustomerId.Text);

                    // execute the query
                    OleDbDataReader reader = myCmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // read the data and put them into text fields
                        lblTitle.Text = reader[0].ToString();
                        lblFirstName.Text = reader[1].ToString();
                        lblLastName.Text = reader[2].ToString();
                    }
                }
                // catch an error and holds all information in ex object
                catch (Exception ex)
                {
                    // display the message window to user informing him about error
                    MessageBox.Show("Error during loading the customer details. Try later.");
                    Console.WriteLine(" ");
                    // display the content of error message as text in console
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        // get the product id after the change in combo box
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            productDetails();
        }

        // get some info about product and convert interest rate for percentage format
        private void productDetails()
        {
            string productId;

            if (cmbChooseTheProduct.Visible == true)
            {
                productId = cmbChooseTheProduct.SelectedValue.ToString();
                txtProductId.Text = productId;
            }
            else productId = txtProductId.Text;

            // create connection with database used the credentials written in connection string
            using (myConn = new OleDbConnection(dbConnection.dbConnect)) // "using" close and dispose the object to allow the resources to be used by other processes
            {
                try
                {
                    // open connection with database used the credentials written in connection string
                    myConn.Open();
                    // sql query send to database is written as string
                    // add parameters to sql query to update data only for only one record using specific customer id
                    string sql = @"SELECT name,status,intrate FROM product WHERE prodid = ?";
                    // create command using sql string and connection with database myConn
                    OleDbCommand myCmd = new OleDbCommand(sql, myConn);

                    // adding parameters to sql query
                    myCmd.Parameters.AddWithValue("prodid", productId);

                    // execute the query
                    OleDbDataReader reader = myCmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // read the data and put them into text fields
                        lblName.Text = reader[0].ToString();
                        lblStatus.Text = reader[1].ToString();
                        // convert interest number to double
                        Object objectInterest = reader[2];
                        double interest = double.Parse(objectInterest.ToString());
                        // calculate percent
                        interest = interest * 100;
                        // display the interest rate
                        lblInterestRate.Text = interest.ToString() + "%";
                    }
                }
                // catch an error and holds all information in ex object
                catch (Exception ex)
                {
                    // display the message window to user informing him about error
                    MessageBox.Show("Error during loading the product details. Try later.");
                    Console.WriteLine(" ");
                    // display the content of error message as text in console
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        // save changes (modify account details)
        private void mnuSaveChanges_Click(object sender, EventArgs e)
        {            
            // create connection with database used the credentials written in connection string
            using (myConn = new OleDbConnection(dbConnection.dbConnect)) // "using" close and dispose the object to allow the resources to be used by other processes
            {
                try
                {
                    // open connection with database used the credentials written in connection string
                    myConn.Open();
                    // sql query send to database is written as string
                    // add parameters to sql query to update data only for only one record using specific customer id
                    string sql = @"UPDATE account SET prodid = ?, startdate = ? WHERE accid = ?;";
                    // create command using sql string and connection with database myConn
                    OleDbCommand myCmd = new OleDbCommand(sql, myConn);

                    // adding parameters to sql query
                    myCmd.Parameters.AddWithValue("prodid", txtProductId.Text);
                    myCmd.Parameters.AddWithValue("startdate", dtpStartDateAccount.Value.ToShortDateString());
                    myCmd.Parameters.AddWithValue("accid", accountID);
                    // execute the query
                    int result = myCmd.ExecuteNonQuery();

                    MessageBox.Show(result + " record was updated");
                }
                // catch an error and holds all information in ex object
                catch (Exception ex)
                {
                    // display the message window to user informing him about error
                    MessageBox.Show("There was some errors during the connection with database. Try again please.");
                    Console.WriteLine(" ");
                    // display the content of error message as text in console
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    this.Dispose();
                }
            }        
        }

        // add new account
        private void mnuNew_Click(object sender, EventArgs e)
        {               
            // create connection with database used the credentials written in connection string
            // "using" close and dispose the object to allow the resources to be used by other processes
            using (myConn = new OleDbConnection(dbConnection.dbConnect))
            {
                try
                {
                    // open connection with database used the credentials written in connection string
                    myConn.Open();
                    // sql query send to database is written as string
                    // add parameters to sql query to insert new record
                    string sql = @"INSERT INTO account (custid, prodid, balance, accrued, active, startdate, status)
                    VALUES (?,?,?,?,?,?,?);";
                    // create command using sql string and connection with database myConn
                    OleDbCommand myCmd = new OleDbCommand(sql, myConn);

                    // adding parameters to sql query

                    myCmd.Parameters.AddWithValue("custid", txtCustomerId.Text);
                    myCmd.Parameters.AddWithValue("prodid", txtProductId.Text);
                    myCmd.Parameters.AddWithValue("balance", 0);
                    myCmd.Parameters.AddWithValue("accrued", 0);
                    myCmd.Parameters.AddWithValue("active", "0");
                    myCmd.Parameters.AddWithValue("startdate", dtpStartDateAccount.Value.ToShortDateString());
                    myCmd.Parameters.AddWithValue("status", "open");
                    // execute the query
                    int result = myCmd.ExecuteNonQuery();

                    MessageBox.Show(result + " new account created.");
                    
                }
                // catch an error and holds all information in ex object
                catch (Exception ex)
                {
                    // display the message window to user informing him about error
                    MessageBox.Show("There was some errors during the connection with database. Try again please.");
                    Console.WriteLine(" ");
                    // display the content of error message as text in console
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    this.Dispose();
                }
            }
        }

        private void mnuMakeTransaction_Click(object sender, EventArgs e)
        {      
            // create new form
            frmNewTransaction transactionForm = new frmNewTransaction(accountID);
            transactionForm.ShowDialog();
        }        
    }
}
