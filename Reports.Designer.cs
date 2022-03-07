
namespace ModernFlatUI
{
    partial class Reports
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
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtbReportContent = new System.Windows.Forms.RichTextBox();
            this.btnMakeTheReport = new System.Windows.Forms.Button();
            this.btnTop10Products = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose the Date period:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rtxtbReportContent
            // 
            this.rtxtbReportContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtbReportContent.Location = new System.Drawing.Point(59, 117);
            this.rtxtbReportContent.Margin = new System.Windows.Forms.Padding(52, 32, 52, 32);
            this.rtxtbReportContent.Name = "rtxtbReportContent";
            this.rtxtbReportContent.ReadOnly = true;
            this.rtxtbReportContent.Size = new System.Drawing.Size(594, 236);
            this.rtxtbReportContent.TabIndex = 3;
            this.rtxtbReportContent.Text = "";
            // 
            // btnMakeTheReport
            // 
            this.btnMakeTheReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMakeTheReport.Location = new System.Drawing.Point(540, 388);
            this.btnMakeTheReport.Margin = new System.Windows.Forms.Padding(2, 2, 52, 32);
            this.btnMakeTheReport.MaximumSize = new System.Drawing.Size(112, 32);
            this.btnMakeTheReport.MinimumSize = new System.Drawing.Size(112, 32);
            this.btnMakeTheReport.Name = "btnMakeTheReport";
            this.btnMakeTheReport.Size = new System.Drawing.Size(112, 32);
            this.btnMakeTheReport.TabIndex = 7;
            this.btnMakeTheReport.Text = "Make the Report";
            this.btnMakeTheReport.UseVisualStyleBackColor = true;
            this.btnMakeTheReport.Click += new System.EventHandler(this.btnMakeTheReport_Click);
            // 
            // btnTop10Products
            // 
            this.btnTop10Products.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTop10Products.Location = new System.Drawing.Point(423, 388);
            this.btnTop10Products.Margin = new System.Windows.Forms.Padding(2, 2, 2, 32);
            this.btnTop10Products.MaximumSize = new System.Drawing.Size(112, 32);
            this.btnTop10Products.MinimumSize = new System.Drawing.Size(112, 32);
            this.btnTop10Products.Name = "btnTop10Products";
            this.btnTop10Products.Size = new System.Drawing.Size(112, 32);
            this.btnTop10Products.TabIndex = 8;
            this.btnTop10Products.Text = "Top 10 Products";
            this.btnTop10Products.UseVisualStyleBackColor = true;
            this.btnTop10Products.Click += new System.EventHandler(this.btnTop10Products_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Start:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "End:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(306, 388);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 32);
            this.btnRefresh.MaximumSize = new System.Drawing.Size(112, 32);
            this.btnRefresh.MinimumSize = new System.Drawing.Size(112, 32);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 32);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd-MM-yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(60, 63);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpStartDate.Size = new System.Drawing.Size(112, 20);
            this.dtpStartDate.TabIndex = 15;
            this.dtpStartDate.Value = new System.DateTime(2021, 1, 1, 14, 2, 0, 0);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd-MM-yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(189, 63);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(112, 20);
            this.dtpEndDate.TabIndex = 16;
            this.dtpEndDate.Value = new System.DateTime(2021, 12, 31, 14, 4, 0, 0);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 460);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTop10Products);
            this.Controls.Add(this.btnMakeTheReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtbReportContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox rtxtbReportContent;
        public System.Windows.Forms.Button btnMakeTheReport;
        public System.Windows.Forms.Button btnTop10Products;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
    }
}