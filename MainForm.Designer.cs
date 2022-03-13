
namespace ModernFlatUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.pnlProductMaintenance = new System.Windows.Forms.Panel();
            this.btnListOfProducts = new System.Windows.Forms.Button();
            this.btnDefineTheProduct = new System.Windows.Forms.Button();
            this.btnProductMaintenance = new System.Windows.Forms.Button();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.btnTenMostSoldItems = new System.Windows.Forms.Button();
            this.btnTotalSalesReport = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnCashRegister = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSubMenu.SuspendLayout();
            this.pnlProductMaintenance.SuspendLayout();
            this.pnlReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSubMenu
            // 
            this.pnlSubMenu.AutoScroll = true;
            this.pnlSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pnlSubMenu.Controls.Add(this.pnlProductMaintenance);
            this.pnlSubMenu.Controls.Add(this.btnProductMaintenance);
            this.pnlSubMenu.Controls.Add(this.pnlReports);
            this.pnlSubMenu.Controls.Add(this.btnReports);
            this.pnlSubMenu.Controls.Add(this.btnCashRegister);
            this.pnlSubMenu.Controls.Add(this.logoPanel);
            this.pnlSubMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSubMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSubMenu.Name = "pnlSubMenu";
            this.pnlSubMenu.Size = new System.Drawing.Size(217, 653);
            this.pnlSubMenu.TabIndex = 0;
            // 
            // pnlProductMaintenance
            // 
            this.pnlProductMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlProductMaintenance.Controls.Add(this.btnListOfProducts);
            this.pnlProductMaintenance.Controls.Add(this.btnDefineTheProduct);
            this.pnlProductMaintenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProductMaintenance.Location = new System.Drawing.Point(0, 233);
            this.pnlProductMaintenance.Name = "pnlProductMaintenance";
            this.pnlProductMaintenance.Size = new System.Drawing.Size(217, 82);
            this.pnlProductMaintenance.TabIndex = 6;
            // 
            // btnListOfProducts
            // 
            this.btnListOfProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListOfProducts.FlatAppearance.BorderSize = 0;
            this.btnListOfProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListOfProducts.ForeColor = System.Drawing.Color.LightGray;
            this.btnListOfProducts.Location = new System.Drawing.Point(0, 40);
            this.btnListOfProducts.Name = "btnListOfProducts";
            this.btnListOfProducts.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListOfProducts.Size = new System.Drawing.Size(217, 40);
            this.btnListOfProducts.TabIndex = 1;
            this.btnListOfProducts.Text = "List of products";
            this.btnListOfProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListOfProducts.UseVisualStyleBackColor = true;
            this.btnListOfProducts.Click += new System.EventHandler(this.btnListOfProducts_Click);
            // 
            // btnDefineTheProduct
            // 
            this.btnDefineTheProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDefineTheProduct.FlatAppearance.BorderSize = 0;
            this.btnDefineTheProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefineTheProduct.ForeColor = System.Drawing.Color.LightGray;
            this.btnDefineTheProduct.Location = new System.Drawing.Point(0, 0);
            this.btnDefineTheProduct.Name = "btnDefineTheProduct";
            this.btnDefineTheProduct.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDefineTheProduct.Size = new System.Drawing.Size(217, 40);
            this.btnDefineTheProduct.TabIndex = 0;
            this.btnDefineTheProduct.Text = "Define the product";
            this.btnDefineTheProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDefineTheProduct.UseVisualStyleBackColor = true;
            this.btnDefineTheProduct.Click += new System.EventHandler(this.btnDefineTheProduct_Click);
            // 
            // btnProductMaintenance
            // 
            this.btnProductMaintenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductMaintenance.FlatAppearance.BorderSize = 0;
            this.btnProductMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductMaintenance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProductMaintenance.Location = new System.Drawing.Point(0, 188);
            this.btnProductMaintenance.Name = "btnProductMaintenance";
            this.btnProductMaintenance.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProductMaintenance.Size = new System.Drawing.Size(217, 45);
            this.btnProductMaintenance.TabIndex = 5;
            this.btnProductMaintenance.Text = "Product Maintenance";
            this.btnProductMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductMaintenance.UseVisualStyleBackColor = true;
            this.btnProductMaintenance.Click += new System.EventHandler(this.btnProductMaintenance_Click);
            // 
            // pnlReports
            // 
            this.pnlReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlReports.Controls.Add(this.btnTenMostSoldItems);
            this.pnlReports.Controls.Add(this.btnTotalSalesReport);
            this.pnlReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReports.Location = new System.Drawing.Point(0, 106);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(217, 82);
            this.pnlReports.TabIndex = 4;
            // 
            // btnTenMostSoldItems
            // 
            this.btnTenMostSoldItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTenMostSoldItems.FlatAppearance.BorderSize = 0;
            this.btnTenMostSoldItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTenMostSoldItems.ForeColor = System.Drawing.Color.LightGray;
            this.btnTenMostSoldItems.Location = new System.Drawing.Point(0, 40);
            this.btnTenMostSoldItems.Name = "btnTenMostSoldItems";
            this.btnTenMostSoldItems.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTenMostSoldItems.Size = new System.Drawing.Size(217, 40);
            this.btnTenMostSoldItems.TabIndex = 1;
            this.btnTenMostSoldItems.Text = "10 most sold items";
            this.btnTenMostSoldItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTenMostSoldItems.UseVisualStyleBackColor = true;
            this.btnTenMostSoldItems.Click += new System.EventHandler(this.btnTenMostSoldItems_Click);
            // 
            // btnTotalSalesReport
            // 
            this.btnTotalSalesReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTotalSalesReport.FlatAppearance.BorderSize = 0;
            this.btnTotalSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalSalesReport.ForeColor = System.Drawing.Color.LightGray;
            this.btnTotalSalesReport.Location = new System.Drawing.Point(0, 0);
            this.btnTotalSalesReport.Name = "btnTotalSalesReport";
            this.btnTotalSalesReport.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTotalSalesReport.Size = new System.Drawing.Size(217, 40);
            this.btnTotalSalesReport.TabIndex = 0;
            this.btnTotalSalesReport.Text = "Total sales report";
            this.btnTotalSalesReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotalSalesReport.UseVisualStyleBackColor = true;
            this.btnTotalSalesReport.Click += new System.EventHandler(this.btnTotalSalesReport_Click);
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReports.Location = new System.Drawing.Point(0, 61);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(217, 45);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnCashRegister
            // 
            this.btnCashRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCashRegister.FlatAppearance.BorderSize = 0;
            this.btnCashRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashRegister.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCashRegister.Location = new System.Drawing.Point(0, 16);
            this.btnCashRegister.Name = "btnCashRegister";
            this.btnCashRegister.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCashRegister.Size = new System.Drawing.Size(217, 45);
            this.btnCashRegister.TabIndex = 1;
            this.btnCashRegister.Text = "Cash Register";
            this.btnCashRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashRegister.UseVisualStyleBackColor = true;
            this.btnCashRegister.Click += new System.EventHandler(this.btnCashRegister_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(217, 16);
            this.logoPanel.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(217, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1065, 653);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSubMenu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cassa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlSubMenu.ResumeLayout(false);
            this.pnlProductMaintenance.ResumeLayout(false);
            this.pnlReports.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSubMenu;
        private System.Windows.Forms.Button btnCashRegister;
        private System.Windows.Forms.Panel logoPanel;
        public System.Windows.Forms.Panel pnlProductMaintenance;
        private System.Windows.Forms.Button btnListOfProducts;
        private System.Windows.Forms.Button btnDefineTheProduct;
        private System.Windows.Forms.Button btnProductMaintenance;
        public System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Button btnTenMostSoldItems;
        private System.Windows.Forms.Button btnTotalSalesReport;
        private System.Windows.Forms.Button btnReports;
        public System.Windows.Forms.Panel pnlMain;
    }
}

