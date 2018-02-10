using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISAManagment
{
    public partial class frmProducts : Form
    {
        // connection to database
        private OleDbConnection myConn;
        // product id number in database 
        private int productID;
        // the interest rate
        double intrate;

        // first constructor
        public frmProducts()
        {
            InitializeComponent();            
            mnuSaveChanges.Visible = false;
        }

        // second constructor
        public frmProducts(Object[] customerDetails, Boolean isReadOnly)
        {
            InitializeComponent();  
         
             // set all text fields just for read only
            if (isReadOnly)
            {
                // change the attribute of text field for read only 
                txtName.ReadOnly = true;
                cmbStatus.Enabled = false;
                cmbTransin.Enabled = false;
                txtIntrate.ReadOnly = true;
                // change the color of font
                txtName.ForeColor = Color.Black;
                cmbStatus.ForeColor = Color.Black;
                cmbTransin.ForeColor = Color.Black;
                txtIntrate.ForeColor = Color.Black;
                // make the menu option unvisible
                mnuNew.Visible = false;
                mnuSaveChanges.Visible = false;
            }
            else
            {
                // make the menu option unvisible
                mnuNew.Visible = false;               
            }

            // populate text fields with customer data
            productID = Int32.Parse(customerDetails[0].ToString());
            txtName.Text = customerDetails[1].ToString();
            cmbStatus.Text = customerDetails[2].ToString();
            cmbTransin.Text = customerDetails[3].ToString();
            txtIntrate.Text = customerDetails[4].ToString();
        }        

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // save changes (modify product details)
        private void mnuSaveChanges_Click(object sender, EventArgs e)
        {         
            // validate the name
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please type in the name of the product.");
                txtName.Focus();
                return;
            }
            
            // validate status
            if ((cmbStatus.Text != "open") && (cmbStatus.Text != "closed"))
            {
                MessageBox.Show("The status has got 'open' or 'closed' value only.");
                // get focus on text field
                cmbStatus.Focus();
                return;
            }

            // validate transacion in
            if ((cmbTransin.Text != "True") && (cmbTransin.Text != "False"))
            {
                MessageBox.Show("The transaction In allowed has got 'True' or 'False' value only.");
                // get focus on text field
                cmbTransin.Focus();
                return;
            }  
            

            // validate the rate of interest            
            string s = txtIntrate.Text;
            if (!string.IsNullOrWhiteSpace(s))
            {                
                if (double.TryParse(txtIntrate.Text, out intrate)) intrate = double.Parse(txtIntrate.Text);
                else
                {
                    MessageBox.Show("Please type in the correct interest number.");
                    txtIntrate.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please type in the correct interest number");
                return;
            }

            // create connection with database used the credentials written in connection string
            using (myConn = new OleDbConnection(dbConnection.dbConnect)) // "using" close and dispose the object to allow the resources to be used by other processes
            {
                try
                {
                    // open connection with database used the credentials written in connection string
                    myConn.Open();
                    // sql query send to database is written as string
                    // add parameters to sql query to update data only for only one record using specific product id
                    string sql = @"UPDATE product SET name = ?, status = ?,
                    transin = ?, intrate = ? WHERE prodid = ?;";
                    // create command using sql string and connection with database myConn
                    OleDbCommand myCmd = new OleDbCommand(sql, myConn);

                    // adding parameters to sql query
                    
                    myCmd.Parameters.AddWithValue("name", txtName.Text);
                    myCmd.Parameters.AddWithValue("status", cmbStatus.Text);
                    string transin = "0";
                    if (cmbTransin.Text == "True") transin = "-1";
                    if (cmbTransin.Text == "False") transin = "0";
                    myCmd.Parameters.AddWithValue("transin", transin);
                    myCmd.Parameters.AddWithValue("intrate", intrate/100);
                    myCmd.Parameters.AddWithValue("prodid", productID);
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

        // add new product
        private void mnuNew_Click(object sender, EventArgs e)
        {
            // validate the name
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please type in the name of the product.");
                txtName.Focus();
                return;
            }

            // validate status
            if ((cmbStatus.Text != "open") && (cmbStatus.Text != "closed"))
            {
                MessageBox.Show("The status has got 'open' or 'closed' value only.");
                // get focus on text field
                cmbStatus.Focus();
                return;
            }

            // validate transacion in
            if ((cmbTransin.Text != "True") && (cmbTransin.Text != "False"))
            {
                MessageBox.Show("The transaction In allowed has got 'True' or 'False' value only.");
                // get focus on text field
                cmbTransin.Focus();
                return;
            }

            // validate the rate of interest            
            string s = txtIntrate.Text;
            if (!string.IsNullOrWhiteSpace(s))
            {
                if (double.TryParse(txtIntrate.Text, out intrate)) intrate = double.Parse(txtIntrate.Text);
                else
                {
                    MessageBox.Show("Please type in the correct interest number.");
                    txtIntrate.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please type in the correct interest number");
                return;
            }

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
                    string sql = @"INSERT INTO product (name, status, transin, intrate)
                    VALUES (?,?,?,?);";
                    // create command using sql string and connection with database myConn
                    OleDbCommand myCmd = new OleDbCommand(sql, myConn);

                    // adding parameters to sql query

                    myCmd.Parameters.AddWithValue("name", txtName.Text);
                    myCmd.Parameters.AddWithValue("status", cmbStatus.Text);
                    string transin = "0";
                    if (cmbTransin.Text == "True") transin = "-1";
                    if (cmbTransin.Text == "False") transin = "0";
                    myCmd.Parameters.AddWithValue("transin", transin);
                    myCmd.Parameters.AddWithValue("intrate", intrate/100);
                    // execute the query
                    int result = myCmd.ExecuteNonQuery();

                    MessageBox.Show(result + " new record was added into database.");
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
        
        // change the all letters to lower case
        private void cmbStatus_Leave(object sender, EventArgs e)
        {            
            cmbStatus.Text = cmbStatus.Text.ToLower();
        }

        // change only first letter to capital letter and other letters to non capital letters
        private void cmbTransin_Leave(object sender, EventArgs e)
        {
            string s = cmbTransin.Text;
            string newString = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0) newString += s.Substring(i, 1).ToUpper();
                else
                {
                    newString += s.Substring(i, 1).ToLower();
                }
            }
            cmbTransin.Text = newString;
        }             
    }
}
