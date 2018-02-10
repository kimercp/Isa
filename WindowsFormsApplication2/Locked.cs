using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISAManagment
{
    public partial class frmLocked : Form
    {
        // password to unlock the application
        private string password;

        public frmLocked(string userPass)
        {
            this.password = userPass;
            InitializeComponent();
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            // check the password
            if (txtPassword.Text != password)
            {
                // set password char \0 refers to a null character (which means this is empty)
                txtPassword.PasswordChar = '\0';
                // set the font color
                txtPassword.ForeColor = Color.Red;
                // show a message for user in text field if the password is not correct
                txtPassword.Text = "Invalid password";
            }
            else                
                // close and dispose the frmLocked window form
                this.Dispose();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            // set the font color
            txtPassword.ForeColor = Color.Black;
            // clear the text field
            txtPassword.Text = "";
            // set the password char for special sign to avoid the password of being compromised
            txtPassword.PasswordChar = '#';
        }

        private void frmLocked_FormClosing(object sender, FormClosingEventArgs e)
        {
            // if user try to close this windom by pressing alt +f4 it will cancel the event
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
        }
    }
}
