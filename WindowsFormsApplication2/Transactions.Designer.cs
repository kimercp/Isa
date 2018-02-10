namespace ISAManagment
{
    partial class frmTransactions
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
            this.mnuAddTransaction = new System.Windows.Forms.MenuStrip();
            this.mnuSumbitTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveChanges = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTransactionId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAction = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDateOfTransaction = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mnuAddTransaction.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.mnuAddTransaction.Location = new System.Drawing.Point(0, 346);
            this.mnuAddTransaction.Name = "mnuAddTransaction";
            this.mnuAddTransaction.Size = new System.Drawing.Size(904, 33);
            this.mnuAddTransaction.TabIndex = 21;
            this.mnuAddTransaction.Text = "Products";
            // 
            // mnuSumbitTransaction
            // 
            this.mnuSumbitTransaction.Name = "mnuSumbitTransaction";
            this.mnuSumbitTransaction.Size = new System.Drawing.Size(186, 29);
            this.mnuSumbitTransaction.Text = "Submit Transaction";
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
            // txtTransactionId
            // 
            this.txtTransactionId.BackColor = System.Drawing.Color.White;
            this.txtTransactionId.Enabled = false;
            this.txtTransactionId.ForeColor = System.Drawing.Color.Maroon;
            this.txtTransactionId.Location = new System.Drawing.Point(130, 37);
            this.txtTransactionId.MaxLength = 255;
            this.txtTransactionId.Name = "txtTransactionId";
            this.txtTransactionId.Size = new System.Drawing.Size(136, 20);
            this.txtTransactionId.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Transaction ID";
            // 
            // txtAccountId
            // 
            this.txtAccountId.BackColor = System.Drawing.Color.White;
            this.txtAccountId.ForeColor = System.Drawing.Color.Maroon;
            this.txtAccountId.Location = new System.Drawing.Point(130, 74);
            this.txtAccountId.MaxLength = 255;
            this.txtAccountId.Name = "txtAccountId";
            this.txtAccountId.Size = new System.Drawing.Size(136, 20);
            this.txtAccountId.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Account ID";
            // 
            // txtAction
            // 
            this.txtAction.BackColor = System.Drawing.Color.White;
            this.txtAction.ForeColor = System.Drawing.Color.Maroon;
            this.txtAction.Location = new System.Drawing.Point(130, 111);
            this.txtAction.MaxLength = 10;
            this.txtAction.Name = "txtAction";
            this.txtAction.Size = new System.Drawing.Size(136, 20);
            this.txtAction.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Action";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            this.txtAmount.ForeColor = System.Drawing.Color.Maroon;
            this.txtAmount.Location = new System.Drawing.Point(130, 148);
            this.txtAmount.MaxLength = 255;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(136, 20);
            this.txtAmount.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Amount of money";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Date";
            // 
            // dtpDateOfTransaction
            // 
            this.dtpDateOfTransaction.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpDateOfTransaction.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfTransaction.Location = new System.Drawing.Point(130, 185);
            this.dtpDateOfTransaction.Name = "dtpDateOfTransaction";
            this.dtpDateOfTransaction.Size = new System.Drawing.Size(136, 20);
            this.dtpDateOfTransaction.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 48);
            this.panel1.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(67, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Transactions Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTransactionId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDateOfTransaction);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAccountId);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAction);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 266);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 379);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnuAddTransaction);
            this.MaximumSize = new System.Drawing.Size(920, 417);
            this.MinimumSize = new System.Drawing.Size(920, 417);
            this.Name = "frmTransactions";
            this.Text = "ISA Transactions";
            this.mnuAddTransaction.ResumeLayout(false);
            this.mnuAddTransaction.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAddTransaction;
        private System.Windows.Forms.ToolStripMenuItem mnuSumbitTransaction;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveChanges;
        private System.Windows.Forms.TextBox txtTransactionId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccountId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDateOfTransaction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}