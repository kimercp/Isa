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
    public partial class frmTransactions : Form
    {
        // transaction id number in database 
        private int transactionID;

        // first constructor
        public frmTransactions(int accountNumber)
        {
            InitializeComponent();
            mnuSaveChanges.Visible = false;
            // copy the account id to text field
            txtAccountId.Text = accountNumber.ToString();
            txtAccountId.Enabled = false;
            dtpDateOfTransaction.Enabled = false;
        }

        // second constructor
        public frmTransactions(Object[] customerDetails, Boolean isReadOnly)
        {
            InitializeComponent();

            // set all text fields just for read only
            if (isReadOnly)
            {
                // change the attribute of text field for read only 
                txtTransactionId.ReadOnly = true;
                txtAccountId.ReadOnly = true;
                txtAction.ReadOnly = true;
                txtAmount.ReadOnly = true;
                dtpDateOfTransaction.Enabled = false;
                // change the color of font
                txtTransactionId.ForeColor = Color.Black;
                txtAccountId.ForeColor = Color.Black;
                txtAction.ForeColor = Color.Black;
                txtAmount.ForeColor = Color.Black;
                dtpDateOfTransaction.CalendarForeColor = Color.Black;
                // make the menu option unvisible
                mnuSumbitTransaction.Visible = false;
                mnuSaveChanges.Visible = false;
            }
            else
            {
                // make the menu option unvisible
                mnuSumbitTransaction.Visible = false;
            }

            // populate text fields with customer data
            transactionID = Int32.Parse(customerDetails[0].ToString());
            txtTransactionId.Text = customerDetails[0].ToString();
            txtAccountId.Text = customerDetails[1].ToString();
            txtAction.Text = customerDetails[2].ToString();
            txtAmount.Text = customerDetails[3].ToString();
            // convert object to date class instance
            dtpDateOfTransaction.Value = DateTime.Parse(customerDetails[4].ToString());

            // make this text field not available to edit but visible for user
            txtTransactionId.Enabled = false;
        }
        
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
