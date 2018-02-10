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
using System.Text.RegularExpressions;

namespace ISAManagment
{
    public partial class frmCustomers : Form
    {
        // connection to database
        private OleDbConnection myConn;
        // customer id number in database 
        private int customerID;

        // first constructor
        public frmCustomers()
        {
            InitializeComponent();
            // remove tab accounts from tabcontrol component
            tbcCustomer.TabPages.Remove(tbpCustomerAccounts);
            // make the menu option unvisible
            mnuSaveChanges.Visible = false;
            mnuView.Visible = false;
            mnuAccount.Visible = false;
            // hide allowance option
            lblAllowance.Visible = false;
            txtAllowance.Visible = false;
        }

        // second constructor 
        public frmCustomers(Object[] customerDetails, Boolean isReadOnly)
        {
            InitializeComponent();

            // set all text fields just for read only
            if (isReadOnly)
            {
                // change the attribute of text field for read only                
                txtTitle.ReadOnly = true;
                txtFirstName.ReadOnly = true;
                txtLastName.ReadOnly = true;
                txtNationalInsurance.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtPassword.ReadOnly = true;
                txtAllowance.ReadOnly = true;
                dtpDateOfBirth.Enabled = false;
                // change the color of font
                txtTitle.ForeColor = Color.Black;
                txtFirstName.ForeColor = Color.Black;
                txtLastName.ForeColor = Color.Black;
                txtNationalInsurance.ForeColor = Color.Black;
                txtEmail.ForeColor = Color.Black;
                txtPassword.ForeColor = Color.Black;
                txtAllowance.ForeColor = Color.Black;                
                // make the menu option unvisible
                mnuAddCustomer.Visible = false;
                mnuSaveChanges.Visible = false;
                mnuView.Visible = false;
                mnuAccount.Visible = false;
            }
            else
            {
                // remove tab accounts from tabcontrol component
                tbcCustomer.TabPages.Remove(tbpCustomerAccounts);
                // make the menu option unvisible
                mnuAddCustomer.Visible = false;
                mnuView.Visible = false;
                mnuAccount.Visible = false;
                // hide allowance option
                lblAllowance.Visible = false;
                txtAllowance.Visible = false;
            }            
           
            // populate text fields with customer data
            // convert object to integer (autonumber in access database)
            customerID = Int32.Parse(customerDetails[0].ToString());
            txtTitle.Text = customerDetails[1].ToString();
            txtFirstName.Text = customerDetails[2].ToString();
            txtLastName.Text = customerDetails[3].ToString();
            // convert object to date class instance
            dtpDateOfBirth.Value = DateTime.Parse(customerDetails[4].ToString());
            txtNationalInsurance.Text = customerDetails[5].ToString();
            txtEmail.Text = customerDetails[6].ToString();
            txtPassword.Text = customerDetails[7].ToString();
            txtAllowance.Text = customerDetails[8].ToString();
            dtpDateOfBirth.CalendarForeColor = Color.Maroon;
        }

        // exit customer form
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // make the option view visible only on page CustomerAccount
        private void tbcCustomer_Click(object sender, EventArgs e)
        {
            // check which tab is selected by user
            if (tbcCustomer.SelectedTab == tbcCustomer.TabPages[1])
            {
                mnuView.Visible = true;
                mnuAccount.Visible = true;
                // create connection with database used the credentials written in connection string
                using (myConn = new OleDbConnection(dbConnection.dbConnect)) // "using" close and dispose the object to allow the resources to be used by other processes
                {
                    try // try..catch will allow to catch unexpected errors and will allow for programmer to handle them safely
                    {
                        // sql query send to database is written as string
                        // add one parameter to sql query to get data only one user with specific customer id
                        string sql = @"SELECT * FROM account WHERE custid = ?";                        
                        // create command using sql string and connection with database myConn
                        OleDbCommand myCmd = new OleDbCommand(sql, myConn);
                        // adding parameters to sql query
                        myCmd.Parameters.AddWithValue("custid", customerID);

                        // create new DataAdapter to read data using sql query received back from database
                        using (OleDbDataAdapter daCustomers = new OleDbDataAdapter(myCmd))
                        {
                            // create new instance of DataTable class
                            DataTable dtCustomers = new DataTable();
                            // fill table with data from data adapter
                            daCustomers.Fill(dtCustomers);
                            // display data onto the gridview
                            dgvDatabaseResults.DataSource = dtCustomers;
                            dgvDatabaseResults.Columns[0].Width = 50;
                            dgvDatabaseResults.Columns[1].Width = 50;
                            dgvDatabaseResults.Columns[2].Width = 50;
                        }
                    }
                    catch (OleDbException ex)
                    { // catch an error and holds all information in ex object
                        // display a message window to user
                        MessageBox.Show("Can not connect to database.");

                        // This is only for my information during the work, User will not see that.
                        // display the content of error message as text in console
                        Console.WriteLine(ex.ToString());
                        // display the error message in console
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            else
            {
                // make the menu option unvisible
                mnuView.Visible = false;
                mnuAccount.Visible = false;
            }
        }

        // save changes (modify customer details)
        private void mnuSaveChanges_Click(object sender, EventArgs e)
        {
            // validate the title (can't contains the numbers, special characters, must start capital letter)
            if (!Regex.IsMatch(txtTitle.Text, "^[A-Z][a-z][a-z]*$"))
            {
                MessageBox.Show("Title must start with capital letter, name can't contain digits or special characters, eg. Mr, Professor");
                // get focus on text field
                txtTitle.Focus();
                return;
            }

            // validate the first name (can't contains the numbers, special characters, must start capital letter)
            if (!Regex.IsMatch(txtFirstName.Text, "^[A-Z][a-z][a-z]*$"))
            {
                MessageBox.Show("First name must start with capital letter, name can't contain digits or special characters, eg. James, Maria");
                // get focus on text field
                txtFirstName.Focus();
                return;
            }

            // validate the last name (can't contains the numbers, special characters, must start capital letter)
            if (!Regex.IsMatch(txtLastName.Text, "^[A-Z][\\-\'\\sa-zA-Z]*[a-z]$"))
            {
                MessageBox.Show("Last name must start with capital letter and can't contain digits eg. Lodbrok, Curie-Sklodowska");
                // get focus on text field
                txtLastName.Focus();
                return;
            }
            
            // validate the national insurance number
            if (!Regex.IsMatch(txtNationalInsurance.Text, "[A-CEGHJ-NOPR-TW-Z]{2}[0-9]{6}[ABCD\\s]{1}"))
            {
                MessageBox.Show("Invalid National Insurance Number");
                // get focus on text field
                txtNationalInsurance.Focus();
                return;
            }

            // validate the email
            if (!Regex.IsMatch(txtEmail.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                MessageBox.Show("Invalid email");
                // get focus on text field
                txtEmail.Focus();
                return;
            }

            // validate the password
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please type in the password.");
                txtPassword.Focus();
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
                    // add parameters to sql query to update data only for only one record using specific customer id
                    string sql = @"UPDATE customer SET title = ?, firstname = ?,
                    lastname = ?, dob = ?, natins = ?, email = ?,
                    pswd = ? WHERE custid = ?;";
                    // create command using sql string and connection with database myConn
                    OleDbCommand myCmd = new OleDbCommand(sql, myConn);

                    // adding parameters to sql query
                    
                    myCmd.Parameters.AddWithValue("title", txtTitle.Text);
                    myCmd.Parameters.AddWithValue("firstname", txtFirstName.Text);
                    myCmd.Parameters.AddWithValue("lastname", txtLastName.Text);                    
                    myCmd.Parameters.AddWithValue("dob", dtpDateOfBirth.Value.ToShortDateString());
                    myCmd.Parameters.AddWithValue("natins", txtNationalInsurance.Text);
                    myCmd.Parameters.AddWithValue("email", txtEmail.Text);
                    myCmd.Parameters.AddWithValue("pswd", txtPassword.Text);
                    myCmd.Parameters.AddWithValue("customerId", customerID);
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

        // adding new customer into database records
        private void mnuAddCustomer_Click(object sender, EventArgs e)
        {
            // validate the title (can't contains the numbers, special characters, must start capital letter)
            if (!Regex.IsMatch(txtTitle.Text, "^[A-Z][a-z][a-z]*$"))
            {
                MessageBox.Show("Title must start with capital letter, name can't contain digits or special characters, eg. Mr, Professor");
                // get focus on text field
                txtTitle.Focus();
                return;
            }

            // validate the first name (can't contains the numbers, special characters, must start capital letter)
            if (!Regex.IsMatch(txtFirstName.Text, "^[A-Z][a-z][a-z]*$"))
            {
                MessageBox.Show("First name must start with capital letter, name can't contain digits or special characters, eg. James, Maria");
                // get focus on text field
                txtFirstName.Focus();
                return;
            }

            // validate the last name (can't contains the numbers, special characters, must start capital letter)
            if (!Regex.IsMatch(txtLastName.Text, "^[A-Z][\\-\'\\sa-zA-Z]*[a-z]$"))
            {
                MessageBox.Show("Last name must start with capital letter and can't contain digits eg. Lodbrok, Curie-Sklodowska");
                // get focus on text field
                txtLastName.Focus();
                return;
            }

            // validate the national insurance number
            if (!Regex.IsMatch(txtNationalInsurance.Text, "[A-CEGHJ-NOPR-TW-Z]{2}[0-9]{6}[ABCD\\s]{1}"))
            {
                MessageBox.Show("Invalid National Insurance Number. All capital letters, please.");
                // get focus on text field
                txtNationalInsurance.Focus();
                return;
            }

            // validate the email
            if (!Regex.IsMatch(txtEmail.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                MessageBox.Show("Invalid email");
                // get focus on text field
                txtEmail.Focus();
                return;
            }

            // validate the password
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {                
                MessageBox.Show("Please type in the password.");
                txtPassword.Focus();
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
                    string sql = @"INSERT INTO customer (title, firstname, lastname, dob, natins, email, pswd, allowance)
                    VALUES (?,?,?,?,?,?,?,?);";
                    // create command using sql string and connection with database myConn
                    OleDbCommand myCmd = new OleDbCommand(sql, myConn);

                    // adding parameters to sql query
                    myCmd.Parameters.AddWithValue("title", txtTitle.Text);
                    myCmd.Parameters.AddWithValue("firstname", txtFirstName.Text);
                    myCmd.Parameters.AddWithValue("lastname", txtLastName.Text);                    
                    myCmd.Parameters.AddWithValue("dob", dtpDateOfBirth.Value.ToShortDateString());
                    myCmd.Parameters.AddWithValue("natins", txtNationalInsurance.Text);
                    myCmd.Parameters.AddWithValue("email", txtEmail.Text);
                    myCmd.Parameters.AddWithValue("pswd", txtPassword.Text);
                    myCmd.Parameters.AddWithValue("allowance", 15240);
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

        private void dgvDatabaseResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {    
            // check if any row is selected 
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // get the number of selected row
                int selectedRow = e.RowIndex;
                // view the choosen form            
                newAccountForm(selectedRow, true);
            }
        }        

        private void mnuView_Click(object sender, EventArgs e)
        {
            // get the number of selected row
            int numberOfRows = dgvDatabaseResults.Rows.Count;
            if (dgvDatabaseResults.Rows.Count != 0 && dgvDatabaseResults.Rows != null)
            {
                int selectedRow = dgvDatabaseResults.CurrentRow.Index;
                newAccountForm(selectedRow, true);
            }  
        }

        private void newAccountForm(int selectedRow, bool p)
        {
            // get the number of columns in data grid view
            int numberOfColumns = dgvDatabaseResults.ColumnCount;
            // create array with objects holds all data from selected row
            Object[] row = new Object[numberOfColumns];

            // check if any row is selected
            if (selectedRow >= 0)
            {
                // this loop will put object to row array from each column from selected row
                for (int i = 0; i < numberOfColumns; i++)
                {
                    row[i] = dgvDatabaseResults[i, selectedRow].Value.ToString();
                }
            }
            else row = null;

            // create new form
            frmAccounts accountForm = new frmAccounts(row, true);
            accountForm.ShowDialog();
        }

        // adding nuew customer's account
        private void mnuAccount_Click(object sender, EventArgs e)
        {
            int numberOfAccounts = dgvDatabaseResults.Rows.Count;
         
            // do only if customer has some accounts
            if (numberOfAccounts > 0)
            {
                // check every account start date account
                for (int i = 0; i < numberOfAccounts; i++)
                {
                    DateTime startAccountDate = DateTime.Parse(dgvDatabaseResults.Rows[i].Cells[6].Value.ToString());
                    if (isDateThisTaxYear(startAccountDate))
                    {
                        MessageBox.Show("Customer created the new account in this tax year. Opening another one is not available.");
                        return;
                    }
                }                
            }
            
            // open an empty form to add new product 
            frmAccounts accountForm = new frmAccounts(customerID);
            accountForm.ShowDialog();
        }

        // checking if the date is between 1.04.17 - 31.03.17
        private bool isDateThisTaxYear(DateTime startAccountDate)
        {
            if (((startAccountDate.Month > 3) && (startAccountDate.Year == DateTime.Now.Year - 1))
                || (startAccountDate.Month < 4) && (startAccountDate.Year == DateTime.Now.Year)) return true;
            return false;
        }

        private void txtNationalInsurance_Leave(object sender, EventArgs e)
        {
            // change all letter to upper case
            txtNationalInsurance.Text = txtNationalInsurance.Text.ToUpper();            
        }
    }
}
