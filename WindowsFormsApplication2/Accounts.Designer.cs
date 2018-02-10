namespace ISAManagment
{
    partial class frmAccounts
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
            this.mnuAddAccount = new System.Windows.Forms.MenuStrip();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveChanges = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMakeTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAccountId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccrued = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbOpenAccount = new System.Windows.Forms.RadioButton();
            this.rbCloseAccount = new System.Windows.Forms.RadioButton();
            this.grbStatusAccount = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpStartDateAccount = new System.Windows.Forms.DateTimePicker();
            this.txtActive = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbChooseTheProduct = new System.Windows.Forms.ComboBox();
            this.grbProductDetails = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mnuAddAccount.SuspendLayout();
            this.grbStatusAccount.SuspendLayout();
            this.grbProductDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAddAccount
            // 
            this.mnuAddAccount.BackColor = System.Drawing.SystemColors.Control;
            this.mnuAddAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mnuAddAccount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAddAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.cancelToolStripMenuItem,
            this.mnuSaveChanges,
            this.mnuMakeTransaction});
            this.mnuAddAccount.Location = new System.Drawing.Point(0, 420);
            this.mnuAddAccount.Name = "mnuAddAccount";
            this.mnuAddAccount.Size = new System.Drawing.Size(904, 33);
            this.mnuAddAccount.TabIndex = 20;
            this.mnuAddAccount.Text = "Products";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(132, 29);
            this.mnuNew.Text = "Add Account";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // mnuSaveChanges
            // 
            this.mnuSaveChanges.Name = "mnuSaveChanges";
            this.mnuSaveChanges.Size = new System.Drawing.Size(83, 29);
            this.mnuSaveChanges.Text = "Modify";
            this.mnuSaveChanges.Click += new System.EventHandler(this.mnuSaveChanges_Click);
            // 
            // mnuMakeTransaction
            // 
            this.mnuMakeTransaction.Name = "mnuMakeTransaction";
            this.mnuMakeTransaction.Size = new System.Drawing.Size(173, 29);
            this.mnuMakeTransaction.Text = "Make Transaction";
            this.mnuMakeTransaction.Click += new System.EventHandler(this.mnuMakeTransaction_Click);
            // 
            // txtAccountId
            // 
            this.txtAccountId.BackColor = System.Drawing.Color.White;
            this.txtAccountId.ForeColor = System.Drawing.Color.Maroon;
            this.txtAccountId.Location = new System.Drawing.Point(94, 33);
            this.txtAccountId.MaxLength = 255;
            this.txtAccountId.Name = "txtAccountId";
            this.txtAccountId.Size = new System.Drawing.Size(102, 20);
            this.txtAccountId.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Account ID";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.BackColor = System.Drawing.Color.White;
            this.txtCustomerId.ForeColor = System.Drawing.Color.Maroon;
            this.txtCustomerId.Location = new System.Drawing.Point(94, 59);
            this.txtCustomerId.MaxLength = 255;
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(102, 20);
            this.txtCustomerId.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Customer ID";
            // 
            // txtProductId
            // 
            this.txtProductId.BackColor = System.Drawing.Color.White;
            this.txtProductId.ForeColor = System.Drawing.Color.Maroon;
            this.txtProductId.Location = new System.Drawing.Point(94, 85);
            this.txtProductId.MaxLength = 255;
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(102, 20);
            this.txtProductId.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Product ID";
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.White;
            this.txtBalance.ForeColor = System.Drawing.Color.Maroon;
            this.txtBalance.Location = new System.Drawing.Point(94, 111);
            this.txtBalance.MaxLength = 255;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(102, 20);
            this.txtBalance.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Balance";
            // 
            // txtAccrued
            // 
            this.txtAccrued.BackColor = System.Drawing.Color.White;
            this.txtAccrued.ForeColor = System.Drawing.Color.Maroon;
            this.txtAccrued.Location = new System.Drawing.Point(94, 137);
            this.txtAccrued.MaxLength = 255;
            this.txtAccrued.Name = "txtAccrued";
            this.txtAccrued.Size = new System.Drawing.Size(102, 20);
            this.txtAccrued.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Accrued Money";
            // 
            // rbOpenAccount
            // 
            this.rbOpenAccount.AutoSize = true;
            this.rbOpenAccount.Location = new System.Drawing.Point(105, 21);
            this.rbOpenAccount.Name = "rbOpenAccount";
            this.rbOpenAccount.Size = new System.Drawing.Size(51, 17);
            this.rbOpenAccount.TabIndex = 43;
            this.rbOpenAccount.TabStop = true;
            this.rbOpenAccount.Text = "Open";
            this.rbOpenAccount.UseVisualStyleBackColor = true;
            // 
            // rbCloseAccount
            // 
            this.rbCloseAccount.AutoSize = true;
            this.rbCloseAccount.Location = new System.Drawing.Point(105, 55);
            this.rbCloseAccount.Name = "rbCloseAccount";
            this.rbCloseAccount.Size = new System.Drawing.Size(57, 17);
            this.rbCloseAccount.TabIndex = 44;
            this.rbCloseAccount.TabStop = true;
            this.rbCloseAccount.Text = "Closed";
            this.rbCloseAccount.UseVisualStyleBackColor = true;
            // 
            // grbStatusAccount
            // 
            this.grbStatusAccount.Controls.Add(this.rbOpenAccount);
            this.grbStatusAccount.Controls.Add(this.rbCloseAccount);
            this.grbStatusAccount.Location = new System.Drawing.Point(12, 300);
            this.grbStatusAccount.Name = "grbStatusAccount";
            this.grbStatusAccount.Size = new System.Drawing.Size(219, 89);
            this.grbStatusAccount.TabIndex = 45;
            this.grbStatusAccount.TabStop = false;
            this.grbStatusAccount.Text = "Status Account";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Start Date";
            // 
            // dtpStartDateAccount
            // 
            this.dtpStartDateAccount.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpStartDateAccount.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDateAccount.Location = new System.Drawing.Point(94, 163);
            this.dtpStartDateAccount.Name = "dtpStartDateAccount";
            this.dtpStartDateAccount.Size = new System.Drawing.Size(102, 20);
            this.dtpStartDateAccount.TabIndex = 47;
            // 
            // txtActive
            // 
            this.txtActive.ForeColor = System.Drawing.Color.Maroon;
            this.txtActive.Location = new System.Drawing.Point(94, 189);
            this.txtActive.Name = "txtActive";
            this.txtActive.Size = new System.Drawing.Size(102, 20);
            this.txtActive.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Active";
            // 
            // cmbChooseTheProduct
            // 
            this.cmbChooseTheProduct.AutoCompleteCustomSource.AddRange(new string[] {
            "Anna",
            "Maciej",
            "Baran",
            "Cycek",
            "Dupek",
            "Ignacy",
            "Zakariusz"});
            this.cmbChooseTheProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbChooseTheProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChooseTheProduct.FormattingEnabled = true;
            this.cmbChooseTheProduct.Location = new System.Drawing.Point(6, 19);
            this.cmbChooseTheProduct.Name = "cmbChooseTheProduct";
            this.cmbChooseTheProduct.Size = new System.Drawing.Size(229, 21);
            this.cmbChooseTheProduct.TabIndex = 50;
            this.cmbChooseTheProduct.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // grbProductDetails
            // 
            this.grbProductDetails.Controls.Add(this.label11);
            this.grbProductDetails.Controls.Add(this.label10);
            this.grbProductDetails.Controls.Add(this.label9);
            this.grbProductDetails.Controls.Add(this.lblInterestRate);
            this.grbProductDetails.Controls.Add(this.lblStatus);
            this.grbProductDetails.Controls.Add(this.lblName);
            this.grbProductDetails.Controls.Add(this.cmbChooseTheProduct);
            this.grbProductDetails.Location = new System.Drawing.Point(237, 160);
            this.grbProductDetails.Name = "grbProductDetails";
            this.grbProductDetails.Size = new System.Drawing.Size(655, 230);
            this.grbProductDetails.TabIndex = 52;
            this.grbProductDetails.TabStop = false;
            this.grbProductDetails.Text = "Product details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(198, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Interest Rate";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestRate.Location = new System.Drawing.Point(238, 162);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(103, 20);
            this.lblInterestRate.TabIndex = 54;
            this.lblInterestRate.Text = "Interest Rate";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(238, 86);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 20);
            this.lblStatus.TabIndex = 53;
            this.lblStatus.Text = "Status";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(238, 122);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 52;
            this.lblName.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Location = new System.Drawing.Point(237, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 78);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(257, 37);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(85, 20);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Wojciekian";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(144, 37);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Anna Marie";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(144, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Mrs";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 48);
            this.panel1.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(86, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Account Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAccountId);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCustomerId);
            this.groupBox2.Controls.Add(this.txtActive);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpStartDateAccount);
            this.groupBox2.Controls.Add(this.txtProductId);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBalance);
            this.groupBox2.Controls.Add(this.txtAccrued);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 228);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbProductDetails);
            this.Controls.Add(this.grbStatusAccount);
            this.Controls.Add(this.mnuAddAccount);
            this.MaximumSize = new System.Drawing.Size(920, 491);
            this.MinimumSize = new System.Drawing.Size(920, 491);
            this.Name = "frmAccounts";
            this.Text = "ISA Accounts";
            this.Load += new System.EventHandler(this.frmAccounts_Load);
            this.mnuAddAccount.ResumeLayout(false);
            this.mnuAddAccount.PerformLayout();
            this.grbStatusAccount.ResumeLayout(false);
            this.grbStatusAccount.PerformLayout();
            this.grbProductDetails.ResumeLayout(false);
            this.grbProductDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAddAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveChanges;
        private System.Windows.Forms.TextBox txtAccountId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccrued;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbOpenAccount;
        private System.Windows.Forms.RadioButton rbCloseAccount;
        private System.Windows.Forms.GroupBox grbStatusAccount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpStartDateAccount;
        private System.Windows.Forms.TextBox txtActive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbChooseTheProduct;
        private System.Windows.Forms.GroupBox grbProductDetails;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem mnuMakeTransaction;
    }
}