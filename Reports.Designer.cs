
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
            this.label1.Location = new System.Drawing.Point(76, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose the Date period:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rtxtbReportContent
            // 
            this.rtxtbReportContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtbReportContent.Location = new System.Drawing.Point(79, 144);
            this.rtxtbReportContent.Margin = new System.Windows.Forms.Padding(69, 39, 69, 39);
            this.rtxtbReportContent.Name = "rtxtbReportContent";
            this.rtxtbReportContent.ReadOnly = true;
            this.rtxtbReportContent.Size = new System.Drawing.Size(791, 290);
            this.rtxtbReportContent.TabIndex = 3;
            this.rtxtbReportContent.Text = "";
            // 
            // btnMakeTheReport
            // 
            this.btnMakeTheReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMakeTheReport.Location = new System.Drawing.Point(720, 478);
            this.btnMakeTheReport.Margin = new System.Windows.Forms.Padding(3, 2, 69, 39);
            this.btnMakeTheReport.MaximumSize = new System.Drawing.Size(149, 39);
            this.btnMakeTheReport.MinimumSize = new System.Drawing.Size(149, 39);
            this.btnMakeTheReport.Name = "btnMakeTheReport";
            this.btnMakeTheReport.Size = new System.Drawing.Size(149, 39);
            this.btnMakeTheReport.TabIndex = 7;
            this.btnMakeTheReport.Text = "Make the Report";
            this.btnMakeTheReport.UseVisualStyleBackColor = true;
            this.btnMakeTheReport.Click += new System.EventHandler(this.btnMakeTheReport_Click);
            // 
            // btnTop10Products
            // 
            this.btnTop10Products.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTop10Products.Location = new System.Drawing.Point(564, 478);
            this.btnTop10Products.Margin = new System.Windows.Forms.Padding(3, 2, 3, 39);
            this.btnTop10Products.MaximumSize = new System.Drawing.Size(149, 39);
            this.btnTop10Products.MinimumSize = new System.Drawing.Size(149, 39);
            this.btnTop10Products.Name = "btnTop10Products";
            this.btnTop10Products.Size = new System.Drawing.Size(149, 39);
            this.btnTop10Products.TabIndex = 8;
            this.btnTop10Products.Text = "Top 10 Products";
            this.btnTop10Products.UseVisualStyleBackColor = true;
            this.btnTop10Products.Click += new System.EventHandler(this.btnTop10Products_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Start:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "End:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(408, 478);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 39);
            this.btnRefresh.MaximumSize = new System.Drawing.Size(149, 39);
            this.btnRefresh.MinimumSize = new System.Drawing.Size(149, 39);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(149, 39);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "yyyy-MM-dd";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(80, 78);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpStartDate.Size = new System.Drawing.Size(148, 22);
            this.dtpStartDate.TabIndex = 15;
            this.dtpStartDate.Value = new System.DateTime(2022, 1, 1, 14, 2, 0, 0);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "yyyy-MM-dd";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(252, 78);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(148, 22);
            this.dtpEndDate.TabIndex = 16;
            this.dtpEndDate.Value = new System.DateTime(2022, 12, 31, 14, 4, 0, 0);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 566);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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