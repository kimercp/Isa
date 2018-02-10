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
    public partial class frmMain : Form
    {
        // connection to database
        private OleDbConnection myConn;
        // number of menu whichFormFlag might be 1-customers, 2-products, 3-transactions, 4-account
        private int whichFormFlag;
        // the password used to log in by user ( I pass it to locked form)
        private string userPass;        
        
        public frmMain(string userPasswordFromDatabase)
        {
            this.userPass = userPasswordFromDatabase;
            InitializeComponent();
            // set lower menu as unvisible until the user press the option from menu
            menuCustomer.Visible = false;
            menuProduct.Visible = false;
            menuAccount.Visible = false;
            menuTransaction.Visible = false;            
        }

        // show data in datagrid from customer table 
        private void mnuCustomers_Click(object sender, EventArgs e)
        {
            // set up menu flag for 1
            whichFormFlag = 1;
            // make another menu list invisible
            menuProduct.Visible = false;
            menuCustomer.Visible = true;
            menuAccount.Visible = false;
            menuTransaction.Visible = false;
            // run sql query to database (passsed argument sql query as string)
            selectQuery("SELECT * FROM customer;");
            // define column width
            dgvDatabaseResults.Columns[0].Width = 40;
            dgvDatabaseResults.Columns[1].Width = 80;
            dgvDatabaseResults.Columns[2].Width = 100;
            dgvDatabaseResults.Columns[3].Width = 100;
            dgvDatabaseResults.Columns[4].Width = 80;
            dgvDatabaseResults.Columns[5].Width = 100;
            dgvDatabaseResults.Columns[6].Width = 200;
            dgvDatabaseResults.Columns[7].Width = 100;
            dgvDatabaseResults.Columns[8].Width = 70;
            // hide group box search
            gbSearch.Visible = false;
            // hide group box details
            gbDetails.Visible = false;
        }

        // show data in datagrid from product table
        private void mnuProducts_Click(object sender, EventArgs e)
        {
            // set up menu flag for 2
            whichFormFlag = 2;
            // make another menu list invisible
            menuCustomer.Visible = false;
            menuProduct.Visible = true;
            menuAccount.Visible = false;
            menuTransaction.Visible = false;
            // run sql query to database (passsed argument sql query as string)
            selectQuery("SELECT * FROM product;");
            // define column width
            dgvDatabaseResults.Columns[0].Width = 40;
            dgvDatabaseResults.Columns[1].Width = 280;
            dgvDatabaseResults.Columns[2].Width = 120;
            dgvDatabaseResults.Columns[3].Width = 120;
            dgvDatabaseResults.Columns[4].Width = 100;
            // hide group box search
            gbSearch.Visible = false;
            // hide group box details
            gbDetails.Visible = false;
        }

        // show data in datagrid from transaction table
        private void mnuTransactions_Click(object sender, EventArgs e)
        {
            // set up menu flag for 3
            whichFormFlag = 3;
            // make another menu list invisible
            menuCustomer.Visible = false;
            menuProduct.Visible = false;
            menuAccount.Visible = false;
            menuTransaction.Visible = true;
            // run sql query to database (passsed argument sql query as string)
            selectQuery("SELECT * FROM tranx;");
            // define column width
            dgvDatabaseResults.Columns[0].Width = 40;
            dgvDatabaseResults.Columns[1].Width = 100;
            dgvDatabaseResults.Columns[2].Width = 120;
            dgvDatabaseResults.Columns[3].Width = 120;
            dgvDatabaseResults.Columns[4].Width = 100;
            // display group box search
            gbSearch.Visible = true;
            // hide group box details
            gbDetails.Visible = false;
            // add all customers to combo box component
            createCustomerList();
        }
        
        // show data in datagrid from account table
        private void mnuAccounts_Click(object sender, EventArgs e)
        {
            // set up menu flag for 4
            whichFormFlag = 4;
            // make another menu list invisible
            menuCustomer.Visible = false;
            menuProduct.Visible = false;
            menuAccount.Visible = true;
            menuTransaction.Visible = false;
            // run sql query to database (passsed argument sql query as string)
            selectQuery(@"SELECT * FROM account;");
            // define column width
            dgvDatabaseResults.Columns[0].Width = 50;
            dgvDatabaseResults.Columns[1].Width = 50;
            dgvDatabaseResults.Columns[2].Width = 50;
            dgvDatabaseResults.Columns[3].Width = 100;
            dgvDatabaseResults.Columns[4].Width = 110;
            dgvDatabaseResults.Columns[5].Width = 110;
            dgvDatabaseResults.Columns[6].Width = 80;
            dgvDatabaseResults.Columns[7].Width = 70;
            // hide group box search
            gbSearch.Visible = false;
            // display group box details
            gbDetails.Visible = true;
        }

        private void selectQuery(string query)
        {
            // create connection with database used the credentials written in connection string
            using (myConn = new OleDbConnection(dbConnection.dbConnect)) // "using" close and dispose the object to allow the resources to be used by other processes
            {
                try // try..catch will allow to catch unexpected errors and will allow for programmer to handle them safely
                {
                    // sql query send to database is written as string
                    string sql = query;

                    // create new DataAdapter to read data using sql query received back from database
                    using (OleDbDataAdapter daCustomers = new OleDbDataAdapter(sql, myConn))
                    {
                        // create new instance of DataTable class
                        DataTable dtCustomers = new DataTable();
                        // fill table with data from data adapter
                        daCustomers.Fill(dtCustomers);
                        // display data onto the gridview
                        dgvDatabaseResults.DataSource = dtCustomers;
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

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // ask user to confirm exit
            if (MessageBox.Show("Are You want to exit the program?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }            
        }

        // this method lock the application to prevent for no authorised access
        private void lockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocked lockedForm;
            lockedForm = new frmLocked(userPass);
            lockedForm.ShowDialog();
        }

        // new customer
        private void mnuNew_Click(object sender, EventArgs e)
        {
            // open an empty form to add new customer 
            frmCustomers customersForm = new frmCustomers();
            customersForm.ShowDialog();
        }
        
        // view customer
        private void mnuViewCustomer_Click(object sender, EventArgs e)
        {
            // get the number of selected row
            int selectedRow = dgvDatabaseResults.CurrentRow.Index;
            // view only customer form, (passed arguments: selected data row, type of form, is the data to read only)
            newFormDetails(selectedRow, "customerForm", true);
        }

        // modify customer
        private void mnuModifyCustomer_Click(object sender, EventArgs e)
        {
            // get the number of selected row
            int selectedRow = dgvDatabaseResults.CurrentRow.Index;
            // edit customer form (passed arguments: selected data row, type of form, is the data to read only)
            newFormDetails(selectedRow, "customerForm", false);
        }

        // new product
        private void mnuNewProduct_Click(object sender, EventArgs e)
        {
            // open an empty form to add new product 
            frmProducts productForm = new frmProducts();
            productForm.ShowDialog();
        }

        // view product
        private void mnuViewProduct_Click(object sender, EventArgs e)
        {
            // get the number of selected row
            int selectedRow = dgvDatabaseResults.CurrentRow.Index;
            // view only customer form, (passed arguments: selected data row, type of form, is the data to read only)
            newFormDetails(selectedRow, "productForm", true);
        }

        // modify product
        private void mnuModifyProduct_Click(object sender, EventArgs e)
        {
            // get the number of selected row
            int selectedRow = dgvDatabaseResults.CurrentRow.Index;
            // edit customer form (passed arguments: selected data row, type of form, is the data to read only)
            newFormDetails(selectedRow, "productForm", false);
        }

        // view by double click on selected row in table
        private void dgvDatabaseResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // check if any row is selected 
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // get the number of selected row
                int selectedRow = e.RowIndex;
                // view the choosen form
                switch (whichFormFlag)
                {
                    case 1:
                        newFormDetails(selectedRow, "customerForm", true);
                        break;
                    case 2:
                        newFormDetails(selectedRow, "productForm", true);
                        break;
                    case 3:
                        newFormDetails(selectedRow, "transactionForm", true);
                        break;
                    case 4:
                        newFormDetails(selectedRow, "accountForm", true);
                        break;
                }           
            }             
        }

        // form manager (passing the data from selected row, choose which form is going to create and status)
        private void newFormDetails(int selectedRow, string formToCreate, Boolean isReadOnly)
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
            switch (formToCreate)
            {
                case "customerForm":
                    frmCustomers customersForm = new frmCustomers(row, isReadOnly);
                    customersForm.ShowDialog();
                    break;
                
                case "productForm":
                    frmProducts productForm = new frmProducts(row, isReadOnly);
                    productForm.ShowDialog();
                    break;
                
                case "transactionForm":
                    frmTransactions transactionForm = new frmTransactions(row, isReadOnly);
                    transactionForm.ShowDialog();
                    break;
                case "accountForm":
                    frmAccounts accountForm = new frmAccounts(row, isReadOnly);
                    accountForm.ShowDialog();
                    break;                    
            }
        }

        // view account
        private void txtViewAccount_Click(object sender, EventArgs e)
        {
            // get the number of selected row
            int selectedRow = dgvDatabaseResults.CurrentRow.Index;
            // view only customer form, (passed arguments: selected data row, type of form, is the data to read only)
            newFormDetails(selectedRow, "accountForm", true);
        }

        // modify account
        private void mnuModifyAccount_Click(object sender, EventArgs e)
        {
            // get the number of selected row
            int selectedRow = dgvDatabaseResults.CurrentRow.Index;
            // edit customer form (passed arguments: selected data row, type of form, is the data to read only)
            newFormDetails(selectedRow, "accountForm", false);
        }

        // view transaction
        private void mnuViewTransaction_Click(object sender, EventArgs e)
        {
            // get the number of selected row
            int numberOfRows = dgvDatabaseResults.Rows.Count;
            if (dgvDatabaseResults.Rows.Count != 0 && dgvDatabaseResults.Rows != null)
            {
                int selectedRow = dgvDatabaseResults.CurrentRow.Index;
                // view only customer form, (passed arguments: selected data row, type of form, is the data to read only)
                newFormDetails(selectedRow, "transactionForm", true);
            }
        }

        // modify transaction
        private void mnuModifyTransaction_Click(object sender, EventArgs e)
        {
            // get the number of selected row
            int selectedRow = dgvDatabaseResults.CurrentRow.Index;
            // edit customer form (passed arguments: selected data row, type of form, is the data to read only)
            newFormDetails(selectedRow, "transactionForm", false);
        }

        // open or close account
        private void mnuOpenCloseAccount_Click(object sender, EventArgs e)
        {
            int selectedRow;
            int numberOfRows = dgvDatabaseResults.Rows.Count;
            // it will hold status of account 0-not active, -1 -active
            string statusAccount;
            // this will get a word open or close depend from status of account
            string textToQuestion;
            

            if (dgvDatabaseResults.Rows.Count != 0 && dgvDatabaseResults.Rows != null)
            {
                // take a number of selected row
                selectedRow = dgvDatabaseResults.CurrentRow.Index;
                // check what value has a cell in collumn of 5 nr index
                if (dgvDatabaseResults.Rows[selectedRow].Cells[7].Value.ToString() == "open")
                {
                    statusAccount = "closed";
                    textToQuestion = "close";
                }
                else
                {
                    statusAccount = "open";
                    textToQuestion = "open";
                }

                // ask user to confirm deactivation of account
                if (MessageBox.Show("Are You sure You want to "+textToQuestion+" the account?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
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
                            string sql = @"UPDATE account SET status = ? WHERE accid = ?;";
                            // create command using sql string and connection with database myConn
                            OleDbCommand myCmd = new OleDbCommand(sql, myConn);                            
                            
                            // convert string to number
                            int accountID = Int32.Parse(dgvDatabaseResults.Rows[selectedRow].Cells[0].Value.ToString());

                            // adding parameters to sql query
                            myCmd.Parameters.AddWithValue("status", statusAccount);
                            myCmd.Parameters.AddWithValue("accid", accountID);
                            // execute the query
                            int result = myCmd.ExecuteNonQuery();

                            MessageBox.Show(result + " account change. Please refresh the table.");
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
                }
            }         
        }

        // perform end of day interest calculation
        private void btnEndOfDay_Click(object sender, EventArgs e)
        {            
            if (MessageBox.Show("Are You sure You want to calculate the daily interests to all the accounts?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                // 1. first select all account into the data grid table
                // make another menu list invisible
                menuCustomer.Visible = false;
                menuProduct.Visible = false;
                menuAccount.Visible = false;
                menuTransaction.Visible = false;
                // run sql query to database (passsed argument sql query as string)
                selectQuery(@"SELECT account.accid, account.balance, account.accrued, product.name, product.intrate
                FROM product INNER JOIN account ON product.prodid = account.prodid
                WHERE account.status ='open';");
                // define column width
                dgvDatabaseResults.Columns[0].Width = 40;
                dgvDatabaseResults.Columns[1].Width = 120;
                dgvDatabaseResults.Columns[2].Width = 120;
                dgvDatabaseResults.Columns[3].Width = 400;
                dgvDatabaseResults.Columns[4].Width = 100;

                //2. get a number of accounts by counting ther rows from select query result
                int numberOfAccounts = dgvDatabaseResults.Rows.Count;
                
                //3. loop does all the calculations and update the result into database
                for (int i = 0; i < numberOfAccounts; i++)
                {
                    // get values which are needed to calculate interest
                    double balance = double.Parse(dgvDatabaseResults.Rows[i].Cells[1].Value.ToString());
                    double accured = double.Parse(dgvDatabaseResults.Rows[i].Cells[2].Value.ToString());
                    double interestRate = double.Parse(dgvDatabaseResults.Rows[i].Cells[4].Value.ToString());
                    // convert string to number
                    int accountID = Int32.Parse(dgvDatabaseResults.Rows[i].Cells[0].Value.ToString());
                    // calculate the interest (daily)
                    accured = accured + (balance * interestRate / 365.0);

                    // create connection with database used the credentials written in connection string
                    using (myConn = new OleDbConnection(dbConnection.dbConnect)) // "using" close and dispose the object to allow the resources to be used by other processes
                    {
                        try
                        {
                            // open connection with database used the credentials written in connection string
                            myConn.Open();
                            // sql query send to database is written as string
                            // add parameters to sql query to update data only for only one record using specific customer id
                            string sql = @"UPDATE account SET accrued = ? WHERE accid = ?;";
                            // create command using sql string and connection with database myConn
                            OleDbCommand myCmd = new OleDbCommand(sql, myConn);                            

                            // adding parameters to sql query
                            myCmd.Parameters.AddWithValue("active", accured);
                            myCmd.Parameters.AddWithValue("accid", accountID);
                            // execute the query
                            int result = myCmd.ExecuteNonQuery();
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
                }
                MessageBox.Show("Please refresh the table.");
            }
        }

        // perform end of year interest calculation
        private void btnEndOfYear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure You want to add all interests into the accounts?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                // 1. first select all account into the data grid table
                // make another menu list invisible
                menuCustomer.Visible = false;
                menuProduct.Visible = false;
                menuAccount.Visible = false;
                menuTransaction.Visible = false;
                // run sql query to database (passsed argument sql query as string)
                selectQuery(@"SELECT accid, balance, accrued FROM account;");
                // define column width
                dgvDatabaseResults.Columns[0].Width = 40;
                dgvDatabaseResults.Columns[1].Width = 120;
                dgvDatabaseResults.Columns[2].Width = 120;
                
                //2. get a number of accounts by counting ther rows from select query result
                int numberOfAccounts = dgvDatabaseResults.Rows.Count;

                //3. loop does all the calculations and update the result into database
                for (int i = 0; i < numberOfAccounts; i++)
                {
                    // get values which are needed to calculate interest
                    int accountID = Int32.Parse(dgvDatabaseResults.Rows[i].Cells[0].Value.ToString());
                    double balance = double.Parse(dgvDatabaseResults.Rows[i].Cells[1].Value.ToString());
                    double accured = double.Parse(dgvDatabaseResults.Rows[i].Cells[2].Value.ToString());
                    // calculate the new balance (all accured interest added to old balance)
                    double newBalance = balance + accured;
                                        
                    // create connection with database used the credentials written in connection string
                    using (myConn = new OleDbConnection(dbConnection.dbConnect)) // "using" close and dispose the object to allow the resources to be used by other processes
                    {
                        try
                        {
                            // open connection with database used the credentials written in connection string
                            myConn.Open();
                            // sql query send to database is written as string
                            // add parameters to sql query to update data only for only one record using specific customer id
                            //string sql = @"UPDATE account SET balance = ?, accrued = 0 WHERE accid = ?;";
                            string sql = @"UPDATE customer INNER JOIN account ON customer.custid = account.custid
                            SET account.balance = ?, account.accrued = 0, customer.allowance = 15240
                            WHERE (((account.accid)=?));";
                            // create command using sql string and connection with database myConn
                            OleDbCommand myCmd = new OleDbCommand(sql, myConn);

                            // adding parameters to sql query
                            myCmd.Parameters.AddWithValue("balance", newBalance);
                            myCmd.Parameters.AddWithValue("accid", accountID);
                            // execute the query
                            int result = myCmd.ExecuteNonQuery();
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
                }
                MessageBox.Show("Please refresh the table.");
            }
        }
        
        // add all customers to combo box component
        private void createCustomerList()
        {
            // create connection with database used the credentials written in connection string
            // "using" close and dispose the object to allow the resources to be used by other processes
            using (myConn = new OleDbConnection(dbConnection.dbConnect))
            {
                try
                {
                    string sql = @"SELECT custid, (title + ' ' + lastname + ' ' + firstname) AS name FROM customer;";
                    
                    // open connection with database used the credentials written in connection string
                    myConn.Open();
                    OleDbCommand myCmd = new OleDbCommand(sql, myConn);
                    OleDbDataReader reader = myCmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    // value member is the customer id
                    cmbSearch.ValueMember = "custid";
                    // that is a text which will display on combo box for user                    
                    cmbSearch.DisplayMember = "name";
                    cmbSearch.DataSource = dt;
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
        }

        // display transactions only for selected customer from combo box
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // create connection with database used the credentials written in connection string
            using (myConn = new OleDbConnection(dbConnection.dbConnect)) // "using" close and dispose the object to allow the resources to be used by other processes
            {
                try // try..catch will allow to catch unexpected errors and will allow for programmer to handle them safely
                {
                    // sql query send to database is written as string
                    // add one parameter to sql query to get data only one user with specific customer id
                    string sql = @"SELECT tranx.trnxid, tranx.accid, tranx.action, tranx.amnt, tranx.event, customer.custid
                    FROM customer INNER JOIN (account INNER JOIN tranx ON account.accid = tranx.accid) ON customer.custid = account.custid
                    WHERE (((customer.custid)=?));";
                    // create command using sql string and connection with database myConn
                    OleDbCommand myCmd = new OleDbCommand(sql, myConn);
                    // adding parameters to sql query
                    myCmd.Parameters.AddWithValue("custid", cmbSearch.SelectedValue.ToString());

                    // create new DataAdapter to read data using sql query received back from database
                    using (OleDbDataAdapter daCustomers = new OleDbDataAdapter(myCmd))
                    {
                        // create new instance of DataTable class
                        DataTable dtCustomers = new DataTable();
                        // fill table with data from data adapter
                        daCustomers.Fill(dtCustomers);
                        // display data onto the gridview
                        dgvDatabaseResults.DataSource = dtCustomers;
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            gbSearch.Visible = false;
            gbDetails.Visible = false;
        }

        // open the forecast form
        private void Forecast_Click(object sender, EventArgs e)
        {
            frmForecast forecastForm = new frmForecast();
            forecastForm.ShowDialog();
        }

        private void dgvDatabaseResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // check if any row is selected 
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // get the number of selected row
                int selectedRow = e.RowIndex;                

                // create connection with database used the credentials written in connection string
                using (myConn = new OleDbConnection(dbConnection.dbConnect)) // "using" close and dispose the object to allow the resources to be used by other processes
                {
                    try
                    {
                        // open connection with database used the credentials written in connection string
                        myConn.Open();
                        // sql query send to database is written as string
                        // add parameters to sql query to update data only for only one record using specific customer id
                        string sql = @"SELECT customer.title, customer.firstname, customer.lastname, product.name
                        FROM product INNER JOIN (customer INNER JOIN account ON customer.custid = account.custid) ON product.prodid = account.prodid
                        WHERE (((account.accid)=[?]));";
                        // create command using sql string and connection with database myConn
                        OleDbCommand myCmd = new OleDbCommand(sql, myConn);

                        // adding parameters to sql query
                        myCmd.Parameters.AddWithValue("accid", dgvDatabaseResults[0,selectedRow].Value.ToString());

                        // execute the query
                        OleDbDataReader reader = myCmd.ExecuteReader();

                        while (reader.Read())
                        {
                            // read the data and put them into text fields
                            lblCustomerName.Text = reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString();
                            lblProductName.Text = reader[3].ToString();
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
        }

        private void btnTotalInvested_Click(object sender, EventArgs e)
        {
            frmTotal totalForm = new frmTotal();
            totalForm.ShowDialog();
        }
              
    } // end of class frmMain
}
