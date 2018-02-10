namespace ISAManagment
{
    partial class frmNewTransaction
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbTransfer = new System.Windows.Forms.GroupBox();
            this.lblTargetAccountName = new System.Windows.Forms.Label();
            this.lblTargetAccountNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTransferToWhom = new System.Windows.Forms.Label();
            this.cmbTargetAccount = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTransfer = new System.Windows.Forms.RadioButton();
            this.rbWithdrawn = new System.Windows.Forms.RadioButton();
            this.rbDeposit = new System.Windows.Forms.RadioButton();
            this.dtpDateOfTransaction = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccountId = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.mnuAddTransaction = new System.Windows.Forms.MenuStrip();
            this.mnuSumbitTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveChanges = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.gbTransfer.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mnuAddTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblProductName);
            this.groupBox1.Controls.Add(this.gbTransfer);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtpDateOfTransaction);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAccountId);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 301);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Product Name";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(127, 19);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(91, 16);
            this.lblProductName.TabIndex = 47;
            this.lblProductName.Text = "Product name";
            // 
            // gbTransfer
            // 
            this.gbTransfer.Controls.Add(this.lblTargetAccountName);
            this.gbTransfer.Controls.Add(this.lblTargetAccountNumber);
            this.gbTransfer.Controls.Add(this.label2);
            this.gbTransfer.Controls.Add(this.lblTransferToWhom);
            this.gbTransfer.Controls.Add(this.cmbTargetAccount);
            this.gbTransfer.Location = new System.Drawing.Point(312, 126);
            this.gbTransfer.Name = "gbTransfer";
            this.gbTransfer.Size = new System.Drawing.Size(547, 160);
            this.gbTransfer.TabIndex = 46;
            this.gbTransfer.TabStop = false;
            this.gbTransfer.Text = "Transfer To:";
            // 
            // lblTargetAccountName
            // 
            this.lblTargetAccountName.AutoSize = true;
            this.lblTargetAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetAccountName.ForeColor = System.Drawing.Color.Maroon;
            this.lblTargetAccountName.Location = new System.Drawing.Point(99, 126);
            this.lblTargetAccountName.Name = "lblTargetAccountName";
            this.lblTargetAccountName.Size = new System.Drawing.Size(68, 20);
            this.lblTargetAccountName.TabIndex = 46;
            this.lblTargetAccountName.Text = "Account";
            // 
            // lblTargetAccountNumber
            // 
            this.lblTargetAccountNumber.AutoSize = true;
            this.lblTargetAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetAccountNumber.ForeColor = System.Drawing.Color.Maroon;
            this.lblTargetAccountNumber.Location = new System.Drawing.Point(99, 101);
            this.lblTargetAccountNumber.Name = "lblTargetAccountNumber";
            this.lblTargetAccountNumber.Size = new System.Drawing.Size(68, 20);
            this.lblTargetAccountNumber.TabIndex = 45;
            this.lblTargetAccountNumber.Text = "Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "The money will be transfered to below account:";
            // 
            // lblTransferToWhom
            // 
            this.lblTransferToWhom.AutoSize = true;
            this.lblTransferToWhom.Location = new System.Drawing.Point(31, 37);
            this.lblTransferToWhom.Name = "lblTransferToWhom";
            this.lblTransferToWhom.Size = new System.Drawing.Size(65, 13);
            this.lblTransferToWhom.TabIndex = 43;
            this.lblTransferToWhom.Text = "Transfer To:";
            // 
            // cmbTargetAccount
            // 
            this.cmbTargetAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetAccount.FormattingEnabled = true;
            this.cmbTargetAccount.Location = new System.Drawing.Point(102, 34);
            this.cmbTargetAccount.Name = "cmbTargetAccount";
            this.cmbTargetAccount.Size = new System.Drawing.Size(408, 21);
            this.cmbTargetAccount.TabIndex = 0;
            this.cmbTargetAccount.SelectedIndexChanged += new System.EventHandler(this.cmbTargetAccount_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblLastName);
            this.groupBox3.Controls.Add(this.lblFirstName);
            this.groupBox3.Controls.Add(this.lblTitle);
            this.groupBox3.Location = new System.Drawing.Point(312, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(547, 70);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(221, 36);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(85, 20);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Wojciekian";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(108, 36);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "Anna Marie";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(108, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 16);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Mrs";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbTransfer);
            this.groupBox2.Controls.Add(this.rbWithdrawn);
            this.groupBox2.Controls.Add(this.rbDeposit);
            this.groupBox2.Location = new System.Drawing.Point(83, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 100);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // rbTransfer
            // 
            this.rbTransfer.AutoSize = true;
            this.rbTransfer.Location = new System.Drawing.Point(68, 70);
            this.rbTransfer.Name = "rbTransfer";
            this.rbTransfer.Size = new System.Drawing.Size(64, 17);
            this.rbTransfer.TabIndex = 2;
            this.rbTransfer.TabStop = true;
            this.rbTransfer.Text = "Transfer";
            this.rbTransfer.UseVisualStyleBackColor = true;
            this.rbTransfer.CheckedChanged += new System.EventHandler(this.rbTransfer_CheckedChanged);
            // 
            // rbWithdrawn
            // 
            this.rbWithdrawn.AutoSize = true;
            this.rbWithdrawn.Location = new System.Drawing.Point(68, 46);
            this.rbWithdrawn.Name = "rbWithdrawn";
            this.rbWithdrawn.Size = new System.Drawing.Size(76, 17);
            this.rbWithdrawn.TabIndex = 1;
            this.rbWithdrawn.TabStop = true;
            this.rbWithdrawn.Text = "Withdrawn";
            this.rbWithdrawn.UseVisualStyleBackColor = true;
            // 
            // rbDeposit
            // 
            this.rbDeposit.AutoSize = true;
            this.rbDeposit.Checked = true;
            this.rbDeposit.Location = new System.Drawing.Point(68, 22);
            this.rbDeposit.Name = "rbDeposit";
            this.rbDeposit.Size = new System.Drawing.Size(61, 17);
            this.rbDeposit.TabIndex = 0;
            this.rbDeposit.TabStop = true;
            this.rbDeposit.Text = "Deposit";
            this.rbDeposit.UseVisualStyleBackColor = true;
            // 
            // dtpDateOfTransaction
            // 
            this.dtpDateOfTransaction.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpDateOfTransaction.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfTransaction.Location = new System.Drawing.Point(130, 59);
            this.dtpDateOfTransaction.Name = "dtpDateOfTransaction";
            this.dtpDateOfTransaction.Size = new System.Drawing.Size(136, 20);
            this.dtpDateOfTransaction.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Account ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Date";
            // 
            // txtAccountId
            // 
            this.txtAccountId.BackColor = System.Drawing.Color.White;
            this.txtAccountId.ForeColor = System.Drawing.Color.Maroon;
            this.txtAccountId.Location = new System.Drawing.Point(130, 96);
            this.txtAccountId.MaxLength = 255;
            this.txtAccountId.Name = "txtAccountId";
            this.txtAccountId.Size = new System.Drawing.Size(136, 20);
            this.txtAccountId.TabIndex = 36;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            this.txtAmount.ForeColor = System.Drawing.Color.Maroon;
            this.txtAmount.Location = new System.Drawing.Point(130, 133);
            this.txtAmount.MaxLength = 255;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(136, 20);
            this.txtAmount.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Amount of money";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 48);
            this.panel1.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(74, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Transactions Details";
            // 
            // mnuAddTransaction
            // 
            this.mnuAddTransaction.BackColor = System.Drawing.SystemColors.Control;
            this.mnuAddTransaction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mnuAddTransaction.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAddTransaction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSumbitTransaction,
            this.cancelToolStripMenuItem,
            this.mnuSaveChanges});
            this.mnuAddTransaction.Location = new System.Drawing.Point(0, 389);
            this.mnuAddTransaction.Name = "mnuAddTransaction";
            this.mnuAddTransaction.Size = new System.Drawing.Size(904, 33);
            this.mnuAddTransaction.TabIndex = 45;
            this.mnuAddTransaction.Text = "Products";
            // 
            // mnuSumbitTransaction
            // 
            this.mnuSumbitTransaction.Name = "mnuSumbitTransaction";
            this.mnuSumbitTransaction.Size = new System.Drawing.Size(186, 29);
            this.mnuSumbitTransaction.Text = "Submit Transaction";
            this.mnuSumbitTransaction.Click += new System.EventHandler(this.mnuSumbitTransaction_Click);
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
            this.mnuSaveChanges.Size = new System.Drawing.Size(141, 29);
            this.mnuSaveChanges.Text = "Save Changes";
            // 
            // frmNewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 422);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnuAddTransaction);
            this.MaximumSize = new System.Drawing.Size(920, 460);
            this.MinimumSize = new System.Drawing.Size(920, 460);
            this.Name = "frmNewTransaction";
            this.Text = "NewTransaction";
            this.Load += new System.EventHandler(this.frmNewTransaction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTransfer.ResumeLayout(false);
            this.gbTransfer.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mnuAddTransaction.ResumeLayout(false);
            this.mnuAddTransaction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTransferToWhom;
        private System.Windows.Forms.ComboBox cmbTargetAccount;
        private System.Windows.Forms.DateTimePicker dtpDateOfTransaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAccountId;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip mnuAddTransaction;
        private System.Windows.Forms.ToolStripMenuItem mnuSumbitTransaction;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveChanges;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbTransfer;
        private System.Windows.Forms.RadioButton rbWithdrawn;
        private System.Windows.Forms.RadioButton rbDeposit;
        private System.Windows.Forms.GroupBox gbTransfer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTargetAccountNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTargetAccountName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label3;
    }
}