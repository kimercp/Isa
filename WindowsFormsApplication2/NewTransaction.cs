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
    public partial class frmNewTransaction : Form
    {
        // connection to database
        private OleDbConnection myConn;
        // customer details
        private int customerId;
        private int accountId;
        private double balance;
        private double allowance;
        private double targetAccountBalance;
        private string title;
        private string firstname;
        private string lastname;
        private string status;
        private string productName;
        // data table used for keep the balance of accounts displayed in combo box
        DataTable accountsBalance = null;

        // amount of money which customer type in into the text field
        double amount;

        // first constructor
        public frmNewTransaction(int accountNumber)
        {
            InitializeComponent();
            // hide label and combo box
            gbTransfer.Visible = false;

            mnuSaveChanges.Visible = false;
            // copy the account id to text field
            txtAccountId.Text = accountNumber.ToString();
            txtAccountId.Enabled = false;
            dtpDateOfTransaction.Enabled = false;
            // assign account nuber to accountId
            this.accountId = accountNumber;
            // get customer data like balance, allowance, title, name, surname
            loadCustomerData();            
        }

        private void loadCustomerData()
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
                    string sql = @"SELECT account.balance, customer.allowance, customer.title, customer.firstname, customer.lastname, account.custid, account.status, product.name
                    FROM product INNER JOIN (customer INNER JOIN account ON customer.custid = account.custid) ON product.prodid = account.prodid
                    WHERE ((account.accid)=?);";
                    /*
                    string sql = @"SELECT account.balance, customer.allowance, customer.title, customer.firstname, customer.lastname, account.custid, account.status
                    FROM customer INNER JOIN account ON customer.custid = account.custid
                    WHERE ((account.accid)=?);";
                     */ 
                    // create command using sql string and connection with database myConn
                    OleDbCommand myCmd = new OleDbCommand(sql, myConn);

                    // adding parameters to sql query
                    myCmd.Parameters.AddWithValue("accid", accountId);

                    // execute the query
                    OleDbDataReader reader = myCmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // read the data and put them into text fields
                        balance = double.Parse(reader[0].ToString());
                        allowance = double.Parse(reader[1].ToString());
                        title = reader[2].ToString();
                        firstname = reader[3].ToString();
                        lastname = reader[4].ToString();
                        customerId = int.Parse(reader[5].ToString());
                        status = reader[6].ToString();
                        productName = reader[7].ToString();
                    }
                    lblTitle.Text = title;
                    lblFirstName.Text = firstname;
                    lblLastName.Text = lastname;
                    lblProductName.Text = productName;
                }
                // catch an error and holds all information in ex object
                catch (Exception ex)
                {
                    // display the message window to user informing him about error
                    MessageBox.Show("Can't connect with database to get customer details. Try later.");
                    Console.WriteLine(" ");
                    // display the content of error message as text in console
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        // display the combo box with accounts where available to transfer money
        private void rbTransfer_CheckedChanged(object sender, EventArgs e)
        {
            // if radiobutton is checked (true)
            if (rbTransfer.Checked)
            {
                // display label and combo box
                gbTransfer.Visible = true;
                // check the balance of target account
                if (accountsBalance != null)
                {
                    foreach (DataRow row in accountsBalance.Rows)
                    //for (int i=0; i<accountsBalance.Rows.Count ; i++)
                    {
                        string accid = row["accid"].ToString();
                        string balance = row["balance"].ToString();
                        if (cmbTargetAccount.SelectedValue.ToString() == accid) targetAccountBalance = double.Parse(balance);
                        // if (accountsBalance.Rows[i][0] == cmbTargetAccount.SelectedValue) targetAccountBalance = double.Parse(accountsBalance.Rows[i][5].ToString());
                    }
                }
            }
            else
            {
                // hide label and combo box
                gbTransfer.Visible = false;                               
            }
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // add new transaction into the database
        private void mnuSumbitTransaction_Click(object sender, EventArgs e)
        {                   
            // validate the amount of money    
            string s = txtAmount.Text;
            // check every char in string for number or dot
            if (!string.IsNullOrWhiteSpace(s))
            {
                double test;
                if (double.TryParse(txtAmount.Text, out test)) amount = double.Parse(txtAmount.Text);
                else
                {
                    MessageBox.Show("Please type in the correct amount of money.");
                    txtAmount.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please type in the correct amount of money.");
                return;
            }            

            // check the action type
            if (rbDeposit.Checked)
            {
                // if deposit ,  allowance - , balance +
                depositMoney();
            }

            if (rbWithdrawn.Checked)
            {
                // if withdrawn, balance -
                withdrawnMoney();
            }

            if (rbTransfer.Checked)
            {
                // if transfer,
                // 1 trans. this account balance -, tranout ,
                // 2 trans. target account ballance +, tranin, allowance -;
                transferMoney();                
            }            
        }

        private void transferMoney()
        {
            // check available money

            /* check the balance of customer */

            if (balance - amount < 0)
            {
                MessageBox.Show("You can't make this transfer. Check Your balance.");
                return;
            }
            
            /* check the allowance of customer */

            if (allowance - amount < 0)
            {
                MessageBox.Show("You can't make this transfer in this tax year because Your all allowance has been already used.");
                return;
            }

            // transfer out acceppted
            // create connection with database used the credentials written in connection string
            // "using" close and dispose the object to allow the resources to be used by other processes
            using (myConn = new OleDbConnection(dbConnection.dbConnect))
            {
                try
                {
                    /* insert first transaction into the database (transfer out)*/

                    // open connection with database used the credentials written in connection string
                    myConn.Open();
                    // sql query send to database is written as string
                    // add parameters to sql query to insert new record
                    string sql = @"INSERT INTO tranx (accid, [action], amnt, event)
                    VALUES (?,?,?,?);";
                    // create command using sql string and connection with database myConn
                    OleDbCommand myCmd = new OleDbCommand(sql, myConn);

                    // adding parameters to sql query
                    string deposit = "tranout";
                    myCmd.Parameters.AddWithValue("accid", accountId);
                    myCmd.Parameters.AddWithValue("action", deposit);
                    myCmd.Parameters.AddWithValue("amnt", amount);
                    myCmd.Parameters.AddWithValue("event", dtpDateOfTransaction.Value.ToShortDateString());
                    // execute the query
                    myCmd.ExecuteNonQuery();

                    /* update the balance */

                    string sqlUpdateBalance = @"UPDATE account SET balance = ? WHERE accid = ?;";
                    // create command using sql string and connection with database myConn
                    OleDbCommand myCmdUpdateBalance = new OleDbCommand(sqlUpdateBalance, myConn);
                    // adding parameters to sql query
                    double newBalance = balance - amount;
                    myCmdUpdateBalance.Parameters.AddWithValue("balance", newBalance);
                    myCmdUpdateBalance.Parameters.AddWithValue("accid", accountId);
                    // execute the query
                    int resultUpdateBalance = myCmdUpdateBalance.ExecuteNonQuery();



                    /* insert second transaction into the database (transfer in)*/                    

                    // transfer in acceppted 
                    
                    // sql query send to database is written as string
                    // add parameters to sql query to insert new record
                    string sqlTransferIn = @"INSERT INTO tranx (accid, [action], amnt, event)
                    VALUES (?,?,?,?);";
                    // create command using sql string and connection with database myConn
                    OleDbCommand myCmdTransferIn = new OleDbCommand(sqlTransferIn, myConn);

                    // adding parameters to sql query
                    string transferin = "tranin";
                    myCmdTransferIn.Parameters.AddWithValue("accid", accountId);
                    myCmdTransferIn.Parameters.AddWithValue("action", transferin);
                    myCmdTransferIn.Parameters.AddWithValue("amnt", amount);
                    myCmdTransferIn.Parameters.AddWithValue("event", dtpDateOfTransaction.Value.ToShortDateString());
                    // execute the query
                    myCmdTransferIn.ExecuteNonQuery();

                    /* update the allowance */

                    // sql query send to database is written as string
                    string sqlUpdateAllowance = @"UPDATE customer SET allowance = ? WHERE custid = ?;";
                    // create command using sql string and connection with database myConn
                    OleDbCommand myCmdUpdate = new OleDbCommand(sqlUpdateAllowance, myConn);
                    // adding parameters to sql query
                    double newAllowance = allowance - amount;
                    myCmdUpdate.Parameters.AddWithValue("allowance", newAllowance);
                    myCmdUpdate.Parameters.AddWithValue("custid", customerId);
                    // execute the query
                    int resultUpdate = myCmdUpdate.ExecuteNonQuery();

                    /* update the balance */

                    // sql query send to database is written as string
                    string sqlUpdateBalance2 = @"UPDATE account SET balance = ?, active = '-1' WHERE accid = ?;";
                    // create command using sql string and connection with database myConn
                    OleDbCommand myCmdUpdateBalance2 = new OleDbCommand(sqlUpdateBalance2, myConn);
                    // adding parameters to sql query
                    double newBalance2 = targetAccountBalance + amount;
                    myCmdUpdateBalance2.Parameters.AddWithValue("balance", newBalance2);
                    myCmdUpdateBalance2.Parameters.AddWithValue("accid", cmbTargetAccount.SelectedValue.ToString());
                    // execute the query
                    myCmdUpdateBalance2.ExecuteNonQuery();

                    MessageBox.Show("New transaction added. Please back to main menu to refresh data.");    
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

        private void depositMoney()
        {
            // check if account is not closed
            if (status == "closed")
            {
                MessageBox.Show("This account is closed. Therefore You can't deposit any money.");
                return;
            }

            /* check the allowance of customer */
            // if deposit ,  allowance - , balance +

            if (allowance - amount < 0)
            {
                MessageBox.Show("You can't make this deposit in this tax year because Your all allowance has been already used.");
                return;
            }

            // deposit acceppted
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
                    string sql = @"INSERT INTO tranx (accid, [action], amnt, event)
                    VALUES (?,?,?,?);";
                    // create command using sql string and connection with database myConn
                    OleDbCommand myCmd = new OleDbCommand(sql, myConn);

                    // adding parameters to sql query
                    string deposit = "deposit";
                    myCmd.Parameters.AddWithValue("accid", accountId);
                    myCmd.Parameters.AddWithValue("action", deposit);
                    myCmd.Parameters.AddWithValue("amnt", amount);
                    myCmd.Parameters.AddWithValue("event", dtpDateOfTransaction.Value.ToShortDateString());
                    // execute the query
                    int result = myCmd.ExecuteNonQuery();

                    /* update the allowance */
                    // sql query send to database is written as string
                    string sqlUpdateAllowance = @"UPDATE customer SET allowance = ? WHERE custid = ?;";
                    // create command using sql string and connection with database myConn
                    OleDbCommand myCmdUpdate = new OleDbCommand(sqlUpdateAllowance, myConn);
                    // adding parameters to sql query
                    double newAllowance = allowance - amount;
                    myCmdUpdate.Parameters.AddWithValue("allowance", newAllowance);
                    myCmdUpdate.Parameters.AddWithValue("custid", customerId);
                    // execute the query
                    int resultUpdate = myCmdUpdate.ExecuteNonQuery();

                    /* update the balance */
                    // sql query send to database is written as string
                    string sqlUpdateBalance = @"UPDATE account SET balance = ?, active = '-1' WHERE accid = ?;";
                    // create command using sql string and connection with database myConn
                    OleDbCommand myCmdUpdateBalance = new OleDbCommand(sqlUpdateBalance, myConn);
                    // adding parameters to sql query
                    double newBalance = balance + amount;
                    myCmdUpdateBalance.Parameters.AddWithValue("balance", newBalance);
                    myCmdUpdateBalance.Parameters.AddWithValue("accid", accountId);
                    // execute the query
                    int resultUpdateBalance = myCmdUpdateBalance.ExecuteNonQuery();

                    MessageBox.Show("New transaction added. Please back to main menu to refresh data.");
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

        private void withdrawnMoney()
        {
            // check available money


            /* check the balance of customer */
            // if withdrawn, balance -

            if (balance - amount < 0)
            {
                MessageBox.Show("You can't make this withdrawn. Check Your balance.");
                return;
            }

            // withdrawn acceppted
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
                    string sql = @"INSERT INTO tranx (accid, [action], amnt, event)
                    VALUES (?,?,?,?);";
                    // create command using sql string and connection with database myConn
                    OleDbCommand myCmd = new OleDbCommand(sql, myConn);

                    // adding parameters to sql query
                    string deposit = "withdrw";
                    myCmd.Parameters.AddWithValue("accid", accountId);
                    myCmd.Parameters.AddWithValue("action", deposit);
                    myCmd.Parameters.AddWithValue("amnt", amount);
                    myCmd.Parameters.AddWithValue("event", dtpDateOfTransaction.Value.ToShortDateString());
                    // execute the query
                    int result = myCmd.ExecuteNonQuery();

                    /* update the balance */
                    // sql query send to database is written as string
                    string sqlUpdateBalance = @"UPDATE account SET balance = ? WHERE accid = ?;";
                    // create command using sql string and connection with database myConn
                    OleDbCommand myCmdUpdateBalance = new OleDbCommand(sqlUpdateBalance, myConn);
                    // adding parameters to sql query
                    double newBalance = balance - amount;
                    myCmdUpdateBalance.Parameters.AddWithValue("balance", newBalance);
                    myCmdUpdateBalance.Parameters.AddWithValue("accid", accountId);
                    // execute the query
                    int resultUpdateBalance = myCmdUpdateBalance.ExecuteNonQuery();

                    MessageBox.Show("New transaction added. Please back to main menu to refresh data.");
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

        // populate combo box
        private void frmNewTransaction_Load(object sender, EventArgs e)
        {
            // create connection with database used the credentials written in connection string
            // "using" close and dispose the object to allow the resources to be used by other processes
            using (myConn = new OleDbConnection(dbConnection.dbConnect))
            {
                try
                {   
                    string sql = @"SELECT account.accid, product.name, product.transin, account.status, account.custid, account.balance
                    FROM product INNER JOIN account ON product.prodid = account.prodid
                    WHERE (((product.transin)=True) AND ((account.status)= 'open') AND ((account.custid)=?) AND (Not [accid]=?));";
                    // open connection with database used the credentials written in connection string
                    myConn.Open();
                    OleDbCommand myCmd = new OleDbCommand(sql, myConn);
                    myCmd.Parameters.AddWithValue("custid", customerId);
                    myCmd.Parameters.AddWithValue("accid", accountId);
                    OleDbDataReader reader = myCmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    //dt.Columns.Add("prodid", typeof(string));
                    //dt.Columns.Add("name", typeof(string));
                    dt.Load(reader);                    
                    
                    // value member is the product id
                    cmbTargetAccount.ValueMember = "accid";
                    // that is a text which will display on combo box for user
                    cmbTargetAccount.DisplayMember = "name";
                    cmbTargetAccount.DataSource = dt;

                    // copy the whole dt to accountsBalance to use it in different method
                    accountsBalance = dt;
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

        private void cmbTargetAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTargetAccountNumber.Text = "Account number: " + cmbTargetAccount.SelectedValue.ToString();
            lblTargetAccountName.Text = "Name: "+cmbTargetAccount.Text;
            if (accountsBalance != null)
            {
                foreach (DataRow row in accountsBalance.Rows)
                //for (int i=0; i<accountsBalance.Rows.Count ; i++)
                {
                    string accid = row["accid"].ToString();
                    string balance = row["balance"].ToString();
                    if (cmbTargetAccount.SelectedValue.ToString() == accid) targetAccountBalance = double.Parse(balance);
                    // if (accountsBalance.Rows[i][0] == cmbTargetAccount.SelectedValue) targetAccountBalance = double.Parse(accountsBalance.Rows[i][5].ToString());
                }              
            }
        }
    }
}
