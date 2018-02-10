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
    public partial class frmTotal : Form
    {
        // connection to database
        private OleDbConnection myConn;

        public frmTotal()
        {
            InitializeComponent();
            // populate the table with data
            loadDataToTable();
            // load data from database to graph
            loadDataToGraph();
        }

        private void loadDataToTable()
        {
            // create connection with database used the credentials written in connection string
            using (myConn = new OleDbConnection(dbConnection.dbConnect)) // "using" close and dispose the object to allow the resources to be used by other processes
            {
                try // try..catch will allow to catch unexpected errors and will allow for programmer to handle them safely
                {
                    // sql query send to database is written as string
                    string sql = @"SELECT Sum(account.balance) AS SumOfbalance, product.name
                    FROM product INNER JOIN account ON product.prodid=account.prodid
                    GROUP BY product.name;";

                    // create new DataAdapter to read data using sql query received back from database
                    using (OleDbDataAdapter daCustomers = new OleDbDataAdapter(sql, myConn))
                    {
                        // create new instance of DataTable class
                        DataTable dtCustomers = new DataTable();
                        // fill table with data from data adapter
                        daCustomers.Fill(dtCustomers);
                        // display data onto the gridview
                        dgvSummary.DataSource = dtCustomers;
                        dgvSummary.Columns[0].Width = 160;
                        dgvSummary.Columns[1].Width = 240;
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

        private void loadDataToGraph()
        {
            // create connection with database used the credentials written in connection string
            // "using" close and dispose the object to allow the resources to be used by other processes
            using (myConn = new OleDbConnection(dbConnection.dbConnect))
            {
                try
                {
                    string sql = @"SELECT Sum(account.balance) AS SumOfbalance, product.name
                    FROM product INNER JOIN account ON product.prodid=account.prodid
                    GROUP BY product.name;";
                    // open connection with database used the credentials written in connection string
                    myConn.Open();
                    OleDbCommand myCmd = new OleDbCommand(sql, myConn);
                   
                    OleDbDataReader reader = myCmd.ExecuteReader();

                    while (reader.Read())
                    {
                        
                        //this.chart1.Series["Total"].Points.AddXY(reader.GetDouble(0),reader.GetString(1));
                        this.chartTotalOfMoney.Series["Total"].Points.AddXY(reader.GetString(1), reader.GetDouble(0));
                    }
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
