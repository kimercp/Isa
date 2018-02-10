namespace ISAManagment
{
    partial class frmCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuCustomer = new System.Windows.Forms.MenuStrip();
            this.mnuAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveChanges = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtNationalInsurance = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.tbcCustomer = new System.Windows.Forms.TabControl();
            this.tbpCustomerDetails = new System.Windows.Forms.TabPage();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblAllowance = new System.Windows.Forms.Label();
            this.txtAllowance = new System.Windows.Forms.TextBox();
            this.tbpCustomerAccounts = new System.Windows.Forms.TabPage();
            this.dgvDatabaseResults = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.menuCustomer.SuspendLayout();
            this.tbcCustomer.SuspendLayout();
            this.tbpCustomerDetails.SuspendLayout();
            this.tbpCustomerAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabaseResults)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuCustomer
            // 
            this.menuCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.menuCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuCustomer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddCustomer,
            this.mnuSaveChanges,
            this.cancelToolStripMenuItem,
            this.mnuView,
            this.mnuAccount});
            this.menuCustomer.Location = new System.Drawing.Point(0, 396);
            this.menuCustomer.Name = "menuCustomer";
            this.menuCustomer.Size = new System.Drawing.Size(882, 33);
            this.menuCustomer.TabIndex = 0;
            this.menuCustomer.Text = "Customers";
            // 
            // mnuAddCustomer
            // 
            this.mnuAddCustomer.Name = "mnuAddCustomer";
            this.mnuAddCustomer.Size = new System.Drawing.Size(144, 29);
            this.mnuAddCustomer.Text = "Add Customer";
            this.mnuAddCustomer.Click += new System.EventHandler(this.mnuAddCustomer_Click);
            // 
            // mnuSaveChanges
            // 
            this.mnuSaveChanges.Name = "mnuSaveChanges";
            this.mnuSaveChanges.Size = new System.Drawing.Size(141, 29);
            this.mnuSaveChanges.Text = "Save Changes";
            this.mnuSaveChanges.Click += new System.EventHandler(this.mnuSaveChanges_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // mnuView
            // 
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(65, 29);
            this.mnuView.Text = "View";
            this.mnuView.Click += new System.EventHandler(this.mnuView_Click);
            // 
            // mnuAccount
            // 
            this.mnuAccount.Name = "mnuAccount";
            this.mnuAccount.Size = new System.Drawing.Size(132, 29);
            this.mnuAccount.Text = "Add Account";
            this.mnuAccount.Click += new System.EventHandler(this.mnuAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "National Insurance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Password";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.White;
            this.txtTitle.ForeColor = System.Drawing.Color.Maroon;
            this.txtTitle.Location = new System.Drawing.Point(125, 36);
            this.txtTitle.MaxLength = 20;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(174, 20);
            this.txtTitle.TabIndex = 11;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.ForeColor = System.Drawing.Color.Maroon;
            this.txtFirstName.Location = new System.Drawing.Point(125, 62);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(174, 20);
            this.txtFirstName.TabIndex = 12;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.ForeColor = System.Drawing.Color.Maroon;
            this.txtLastName.Location = new System.Drawing.Point(125, 88);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(174, 20);
            this.txtLastName.TabIndex = 13;
            // 
            // txtNationalInsurance
            // 
            this.txtNationalInsurance.BackColor = System.Drawing.Color.White;
            this.txtNationalInsurance.ForeColor = System.Drawing.Color.Maroon;
            this.txtNationalInsurance.Location = new System.Drawing.Point(125, 140);
            this.txtNationalInsurance.MaxLength = 9;
            this.txtNationalInsurance.Name = "txtNationalInsurance";
            this.txtNationalInsurance.Size = new System.Drawing.Size(174, 20);
            this.txtNationalInsurance.TabIndex = 15;
            this.txtNationalInsurance.Leave += new System.EventHandler(this.txtNationalInsurance_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.ForeColor = System.Drawing.Color.Maroon;
            this.txtEmail.Location = new System.Drawing.Point(125, 166);
            this.txtEmail.MaxLength = 150;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(174, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.ForeColor = System.Drawing.Color.Maroon;
            this.txtPassword.Location = new System.Drawing.Point(125, 192);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(174, 20);
            this.txtPassword.TabIndex = 17;
            // 
            // tbcCustomer
            // 
            this.tbcCustomer.Controls.Add(this.tbpCustomerDetails);
            this.tbcCustomer.Controls.Add(this.tbpCustomerAccounts);
            this.tbcCustomer.Location = new System.Drawing.Point(12, 70);
            this.tbcCustomer.Name = "tbcCustomer";
            this.tbcCustomer.SelectedIndex = 0;
            this.tbcCustomer.Size = new System.Drawing.Size(858, 312);
            this.tbcCustomer.TabIndex = 0;
            this.tbcCustomer.Click += new System.EventHandler(this.tbcCustomer_Click);
            // 
            // tbpCustomerDetails
            // 
            this.tbpCustomerDetails.BackColor = System.Drawing.SystemColors.Control;
            this.tbpCustomerDetails.Controls.Add(this.dtpDateOfBirth);
            this.tbpCustomerDetails.Controls.Add(this.lblAllowance);
            this.tbpCustomerDetails.Controls.Add(this.label7);
            this.tbpCustomerDetails.Controls.Add(this.txtEmail);
            this.tbpCustomerDetails.Controls.Add(this.label6);
            this.tbpCustomerDetails.Controls.Add(this.txtLastName);
            this.tbpCustomerDetails.Controls.Add(this.label5);
            this.tbpCustomerDetails.Controls.Add(this.txtPassword);
            this.tbpCustomerDetails.Controls.Add(this.label4);
            this.tbpCustomerDetails.Controls.Add(this.txtNationalInsurance);
            this.tbpCustomerDetails.Controls.Add(this.label3);
            this.tbpCustomerDetails.Controls.Add(this.txtAllowance);
            this.tbpCustomerDetails.Controls.Add(this.label2);
            this.tbpCustomerDetails.Controls.Add(this.txtFirstName);
            this.tbpCustomerDetails.Controls.Add(this.label1);
            this.tbpCustomerDetails.Controls.Add(this.txtTitle);
            this.tbpCustomerDetails.Location = new System.Drawing.Point(4, 22);
            this.tbpCustomerDetails.Name = "tbpCustomerDetails";
            this.tbpCustomerDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCustomerDetails.Size = new System.Drawing.Size(850, 286);
            this.tbpCustomerDetails.TabIndex = 0;
            this.tbpCustomerDetails.Text = "Details              ";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(125, 114);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(174, 20);
            this.dtpDateOfBirth.TabIndex = 14;
            // 
            // lblAllowance
            // 
            this.lblAllowance.AutoSize = true;
            this.lblAllowance.Location = new System.Drawing.Point(56, 217);
            this.lblAllowance.Name = "lblAllowance";
            this.lblAllowance.Size = new System.Drawing.Size(56, 13);
            this.lblAllowance.TabIndex = 8;
            this.lblAllowance.Text = "Allowance";
            // 
            // txtAllowance
            // 
            this.txtAllowance.BackColor = System.Drawing.Color.White;
            this.txtAllowance.ForeColor = System.Drawing.Color.Maroon;
            this.txtAllowance.Location = new System.Drawing.Point(125, 218);
            this.txtAllowance.Name = "txtAllowance";
            this.txtAllowance.Size = new System.Drawing.Size(174, 20);
            this.txtAllowance.TabIndex = 18;
            // 
            // tbpCustomerAccounts
            // 
            this.tbpCustomerAccounts.BackColor = System.Drawing.SystemColors.Control;
            this.tbpCustomerAccounts.Controls.Add(this.dgvDatabaseResults);
            this.tbpCustomerAccounts.Location = new System.Drawing.Point(4, 22);
            this.tbpCustomerAccounts.Name = "tbpCustomerAccounts";
            this.tbpCustomerAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCustomerAccounts.Size = new System.Drawing.Size(850, 286);
            this.tbpCustomerAccounts.TabIndex = 1;
            this.tbpCustomerAccounts.Text = "Accounts              ";
            // 
            // dgvDatabaseResults
            // 
            this.dgvDatabaseResults.AllowUserToAddRows = false;
            this.dgvDatabaseResults.AllowUserToDeleteRows = false;
            this.dgvDatabaseResults.AllowUserToOrderColumns = true;
            this.dgvDatabaseResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dgvDatabaseResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatabaseResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatabaseResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDatabaseResults.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvDatabaseResults.Location = new System.Drawing.Point(6, 6);
            this.dgvDatabaseResults.MultiSelect = false;
            this.dgvDatabaseResults.Name = "dgvDatabaseResults";
            this.dgvDatabaseResults.RowHeadersVisible = false;
            this.dgvDatabaseResults.RowTemplate.ReadOnly = true;
            this.dgvDatabaseResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatabaseResults.Size = new System.Drawing.Size(838, 274);
            this.dgvDatabaseResults.TabIndex = 6;
            this.dgvDatabaseResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatabaseResults_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 48);
            this.panel1.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(95, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Customer Details";
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 429);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbcCustomer);
            this.Controls.Add(this.menuCustomer);
            this.MainMenuStrip = this.menuCustomer;
            this.MaximumSize = new System.Drawing.Size(898, 467);
            this.MinimumSize = new System.Drawing.Size(898, 467);
            this.Name = "frmCustomers";
            this.Text = "ISA Customers";
            this.menuCustomer.ResumeLayout(false);
            this.menuCustomer.PerformLayout();
            this.tbcCustomer.ResumeLayout(false);
            this.tbpCustomerDetails.ResumeLayout(false);
            this.tbpCustomerDetails.PerformLayout();
            this.tbpCustomerAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabaseResults)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveChanges;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtNationalInsurance;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TabControl tbcCustomer;
        private System.Windows.Forms.TabPage tbpCustomerDetails;
        private System.Windows.Forms.TabPage tbpCustomerAccounts;
        private System.Windows.Forms.ToolStripMenuItem mnuAddCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.DataGridView dgvDatabaseResults;
        private System.Windows.Forms.ToolStripMenuItem mnuAccount;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblAllowance;
        private System.Windows.Forms.TextBox txtAllowance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}