namespace ISAManagment
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dgvDatabaseResults = new System.Windows.Forms.DataGridView();
            this.menuAccount = new System.Windows.Forms.MenuStrip();
            this.txtViewAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModifyAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenCloseAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTransaction = new System.Windows.Forms.MenuStrip();
            this.mnuViewTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustomer = new System.Windows.Forms.MenuStrip();
            this.mnuViewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModifyCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProduct = new System.Windows.Forms.MenuStrip();
            this.mnuViewProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModifyProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEndOfDay = new System.Windows.Forms.Button();
            this.btnEndOfYear = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnForecast = new System.Windows.Forms.Button();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTotalInvested = new System.Windows.Forms.Button();
            this.mnuCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransactions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabaseResults)).BeginInit();
            this.menuAccount.SuspendLayout();
            this.menuTransaction.SuspendLayout();
            this.menuCustomer.SuspendLayout();
            this.menuProduct.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCustomers,
            this.mnuProducts,
            this.mnuTransactions,
            this.mnuAccounts,
            this.lockToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1088, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mnuMainMenu";
            // 
            // dgvDatabaseResults
            // 
            this.dgvDatabaseResults.AllowUserToAddRows = false;
            this.dgvDatabaseResults.AllowUserToDeleteRows = false;
            this.dgvDatabaseResults.AllowUserToOrderColumns = true;
            this.dgvDatabaseResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dgvDatabaseResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatabaseResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatabaseResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDatabaseResults.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvDatabaseResults.Location = new System.Drawing.Point(22, 97);
            this.dgvDatabaseResults.MultiSelect = false;
            this.dgvDatabaseResults.Name = "dgvDatabaseResults";
            this.dgvDatabaseResults.RowHeadersVisible = false;
            this.dgvDatabaseResults.RowTemplate.ReadOnly = true;
            this.dgvDatabaseResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatabaseResults.Size = new System.Drawing.Size(878, 383);
            this.dgvDatabaseResults.TabIndex = 5;
            this.dgvDatabaseResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatabaseResults_CellClick);
            this.dgvDatabaseResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatabaseResults_CellDoubleClick);
            // 
            // menuAccount
            // 
            this.menuAccount.BackColor = System.Drawing.SystemColors.Control;
            this.menuAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtViewAccount,
            this.mnuModifyAccount,
            this.mnuOpenCloseAccount});
            this.menuAccount.Location = new System.Drawing.Point(0, 396);
            this.menuAccount.Name = "menuAccount";
            this.menuAccount.Size = new System.Drawing.Size(1088, 29);
            this.menuAccount.TabIndex = 4;
            this.menuAccount.Text = "Sellers";
            // 
            // txtViewAccount
            // 
            this.txtViewAccount.Name = "txtViewAccount";
            this.txtViewAccount.Size = new System.Drawing.Size(56, 25);
            this.txtViewAccount.Text = "View";
            this.txtViewAccount.Click += new System.EventHandler(this.txtViewAccount_Click);
            // 
            // mnuModifyAccount
            // 
            this.mnuModifyAccount.Name = "mnuModifyAccount";
            this.mnuModifyAccount.Size = new System.Drawing.Size(71, 25);
            this.mnuModifyAccount.Text = "Modify";
            this.mnuModifyAccount.Click += new System.EventHandler(this.mnuModifyAccount_Click);
            // 
            // mnuOpenCloseAccount
            // 
            this.mnuOpenCloseAccount.Name = "mnuOpenCloseAccount";
            this.mnuOpenCloseAccount.Size = new System.Drawing.Size(164, 25);
            this.mnuOpenCloseAccount.Text = "Open/Close Account";
            this.mnuOpenCloseAccount.Click += new System.EventHandler(this.mnuOpenCloseAccount_Click);
            // 
            // menuTransaction
            // 
            this.menuTransaction.BackColor = System.Drawing.SystemColors.Control;
            this.menuTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuTransaction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuTransaction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTransaction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewTransaction});
            this.menuTransaction.Location = new System.Drawing.Point(0, 425);
            this.menuTransaction.Name = "menuTransaction";
            this.menuTransaction.Size = new System.Drawing.Size(1088, 29);
            this.menuTransaction.TabIndex = 3;
            this.menuTransaction.Text = "Transactions";
            // 
            // mnuViewTransaction
            // 
            this.mnuViewTransaction.Name = "mnuViewTransaction";
            this.mnuViewTransaction.Size = new System.Drawing.Size(56, 25);
            this.mnuViewTransaction.Text = "View";
            this.mnuViewTransaction.Click += new System.EventHandler(this.mnuViewTransaction_Click);
            // 
            // menuCustomer
            // 
            this.menuCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.menuCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewCustomer,
            this.mnuModifyCustomer,
            this.mnuNewCustomer});
            this.menuCustomer.Location = new System.Drawing.Point(0, 454);
            this.menuCustomer.Name = "menuCustomer";
            this.menuCustomer.Size = new System.Drawing.Size(1088, 29);
            this.menuCustomer.TabIndex = 1;
            this.menuCustomer.Text = "Customers";
            // 
            // mnuViewCustomer
            // 
            this.mnuViewCustomer.Name = "mnuViewCustomer";
            this.mnuViewCustomer.Size = new System.Drawing.Size(56, 25);
            this.mnuViewCustomer.Text = "View";
            this.mnuViewCustomer.Click += new System.EventHandler(this.mnuViewCustomer_Click);
            // 
            // mnuModifyCustomer
            // 
            this.mnuModifyCustomer.Name = "mnuModifyCustomer";
            this.mnuModifyCustomer.Size = new System.Drawing.Size(71, 25);
            this.mnuModifyCustomer.Text = "Modify";
            this.mnuModifyCustomer.Click += new System.EventHandler(this.mnuModifyCustomer_Click);
            // 
            // mnuNewCustomer
            // 
            this.mnuNewCustomer.Name = "mnuNewCustomer";
            this.mnuNewCustomer.Size = new System.Drawing.Size(126, 25);
            this.mnuNewCustomer.Text = "New Customer";
            this.mnuNewCustomer.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // menuProduct
            // 
            this.menuProduct.AccessibleDescription = "";
            this.menuProduct.BackColor = System.Drawing.SystemColors.Control;
            this.menuProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewProduct,
            this.mnuModifyProduct,
            this.mnuNewProduct});
            this.menuProduct.Location = new System.Drawing.Point(0, 483);
            this.menuProduct.Name = "menuProduct";
            this.menuProduct.Size = new System.Drawing.Size(1088, 29);
            this.menuProduct.TabIndex = 2;
            this.menuProduct.Text = "Products";
            // 
            // mnuViewProduct
            // 
            this.mnuViewProduct.Name = "mnuViewProduct";
            this.mnuViewProduct.Size = new System.Drawing.Size(56, 25);
            this.mnuViewProduct.Text = "View";
            this.mnuViewProduct.Click += new System.EventHandler(this.mnuViewProduct_Click);
            // 
            // mnuModifyProduct
            // 
            this.mnuModifyProduct.Name = "mnuModifyProduct";
            this.mnuModifyProduct.Size = new System.Drawing.Size(71, 25);
            this.mnuModifyProduct.Text = "Modify";
            this.mnuModifyProduct.Click += new System.EventHandler(this.mnuModifyProduct_Click);
            // 
            // mnuNewProduct
            // 
            this.mnuNewProduct.Name = "mnuNewProduct";
            this.mnuNewProduct.Size = new System.Drawing.Size(112, 25);
            this.mnuNewProduct.Text = "New Product";
            this.mnuNewProduct.Click += new System.EventHandler(this.mnuNewProduct_Click);
            // 
            // btnEndOfDay
            // 
            this.btnEndOfDay.Location = new System.Drawing.Point(43, 24);
            this.btnEndOfDay.Name = "btnEndOfDay";
            this.btnEndOfDay.Size = new System.Drawing.Size(75, 23);
            this.btnEndOfDay.TabIndex = 6;
            this.btnEndOfDay.Text = "End of Day";
            this.btnEndOfDay.UseVisualStyleBackColor = true;
            this.btnEndOfDay.Click += new System.EventHandler(this.btnEndOfDay_Click);
            // 
            // btnEndOfYear
            // 
            this.btnEndOfYear.Location = new System.Drawing.Point(43, 64);
            this.btnEndOfYear.Name = "btnEndOfYear";
            this.btnEndOfYear.Size = new System.Drawing.Size(75, 23);
            this.btnEndOfYear.TabIndex = 7;
            this.btnEndOfYear.Text = "End of Year";
            this.btnEndOfYear.UseVisualStyleBackColor = true;
            this.btnEndOfYear.Click += new System.EventHandler(this.btnEndOfYear_Click);
            // 
            // cmbSearch
            // 
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(6, 21);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(145, 21);
            this.cmbSearch.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(157, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(52, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.cmbSearch);
            this.gbSearch.Location = new System.Drawing.Point(22, 40);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(878, 51);
            this.gbSearch.TabIndex = 11;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Customer List:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEndOfDay);
            this.groupBox1.Controls.Add(this.btnEndOfYear);
            this.groupBox1.Location = new System.Drawing.Point(919, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administer Interest";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnForecast);
            this.groupBox2.Location = new System.Drawing.Point(919, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 111);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extra features";
            // 
            // btnForecast
            // 
            this.btnForecast.Location = new System.Drawing.Point(43, 33);
            this.btnForecast.Name = "btnForecast";
            this.btnForecast.Size = new System.Drawing.Size(75, 47);
            this.btnForecast.TabIndex = 0;
            this.btnForecast.Text = "Forecasting Balance";
            this.btnForecast.UseVisualStyleBackColor = true;
            this.btnForecast.Click += new System.EventHandler(this.Forecast_Click);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.lblProductName);
            this.gbDetails.Controls.Add(this.label2);
            this.gbDetails.Controls.Add(this.lblCustomerName);
            this.gbDetails.Controls.Add(this.label1);
            this.gbDetails.Location = new System.Drawing.Point(22, 40);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(878, 51);
            this.gbDetails.TabIndex = 14;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(66, 20);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(13, 13);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(322, 20);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(13, 13);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "?";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTotalInvested);
            this.groupBox3.Location = new System.Drawing.Point(919, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 111);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total invested:";
            // 
            // btnTotalInvested
            // 
            this.btnTotalInvested.Location = new System.Drawing.Point(43, 37);
            this.btnTotalInvested.Name = "btnTotalInvested";
            this.btnTotalInvested.Size = new System.Drawing.Size(75, 44);
            this.btnTotalInvested.TabIndex = 1;
            this.btnTotalInvested.Text = "Total";
            this.btnTotalInvested.UseVisualStyleBackColor = true;
            this.btnTotalInvested.Click += new System.EventHandler(this.btnTotalInvested_Click);
            // 
            // mnuCustomers
            // 
            this.mnuCustomers.Image = ((System.Drawing.Image)(resources.GetObject("mnuCustomers.Image")));
            this.mnuCustomers.Name = "mnuCustomers";
            this.mnuCustomers.Size = new System.Drawing.Size(129, 29);
            this.mnuCustomers.Text = "Customers";
            this.mnuCustomers.Click += new System.EventHandler(this.mnuCustomers_Click);
            // 
            // mnuProducts
            // 
            this.mnuProducts.Image = ((System.Drawing.Image)(resources.GetObject("mnuProducts.Image")));
            this.mnuProducts.Name = "mnuProducts";
            this.mnuProducts.Size = new System.Drawing.Size(114, 29);
            this.mnuProducts.Text = "Products";
            this.mnuProducts.Click += new System.EventHandler(this.mnuProducts_Click);
            // 
            // mnuTransactions
            // 
            this.mnuTransactions.Image = ((System.Drawing.Image)(resources.GetObject("mnuTransactions.Image")));
            this.mnuTransactions.Name = "mnuTransactions";
            this.mnuTransactions.Size = new System.Drawing.Size(146, 29);
            this.mnuTransactions.Text = "Transactions";
            this.mnuTransactions.Click += new System.EventHandler(this.mnuTransactions_Click);
            // 
            // mnuAccounts
            // 
            this.mnuAccounts.Image = global::ISAManagment.Properties.Resources.account;
            this.mnuAccounts.Name = "mnuAccounts";
            this.mnuAccounts.Size = new System.Drawing.Size(117, 29);
            this.mnuAccounts.Text = "Accounts";
            this.mnuAccounts.Click += new System.EventHandler(this.mnuAccounts_Click);
            // 
            // lockToolStripMenuItem
            // 
            this.lockToolStripMenuItem.Image = global::ISAManagment.Properties.Resources.locks;
            this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            this.lockToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.lockToolStripMenuItem.Text = "Lock";
            this.lockToolStripMenuItem.Click += new System.EventHandler(this.lockToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 512);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.dgvDatabaseResults);
            this.Controls.Add(this.menuAccount);
            this.Controls.Add(this.menuTransaction);
            this.Controls.Add(this.menuCustomer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuProduct);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1100, 550);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ISA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabaseResults)).EndInit();
            this.menuAccount.ResumeLayout(false);
            this.menuAccount.PerformLayout();
            this.menuTransaction.ResumeLayout(false);
            this.menuTransaction.PerformLayout();
            this.menuCustomer.ResumeLayout(false);
            this.menuCustomer.PerformLayout();
            this.menuProduct.ResumeLayout(false);
            this.menuProduct.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomers;
        private System.Windows.Forms.ToolStripMenuItem mnuProducts;
        private System.Windows.Forms.ToolStripMenuItem mnuTransactions;
        private System.Windows.Forms.ToolStripMenuItem mnuAccounts;
        private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuNewCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuViewCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuModifyCustomer;
        private System.Windows.Forms.MenuStrip menuProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuNewProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuViewProduct;
        private System.Windows.Forms.MenuStrip menuTransaction;
        private System.Windows.Forms.ToolStripMenuItem mnuViewTransaction;
        private System.Windows.Forms.MenuStrip menuAccount;
        private System.Windows.Forms.ToolStripMenuItem txtViewAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuModifyAccount;
        private System.Windows.Forms.DataGridView dgvDatabaseResults;
        private System.Windows.Forms.ToolStripMenuItem mnuModifyProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenCloseAccount;
        private System.Windows.Forms.Button btnEndOfDay;
        private System.Windows.Forms.Button btnEndOfYear;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnForecast;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTotalInvested;
    }
}

