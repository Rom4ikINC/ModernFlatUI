
namespace ModernFlatUI
{
    partial class ListofProducts2
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
            this.dataloadwindow = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddTheProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataloadwindow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataloadwindow
            // 
            this.dataloadwindow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataloadwindow.Location = new System.Drawing.Point(56, 46);
            this.dataloadwindow.Name = "dataloadwindow";
            this.dataloadwindow.Size = new System.Drawing.Size(675, 311);
            this.dataloadwindow.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(56, 387);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.MaximumSize = new System.Drawing.Size(112, 32);
            this.button1.MinimumSize = new System.Drawing.Size(112, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Products List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.dataloadwindow_Click);
            // 
            // btnAddTheProduct
            // 
            this.btnAddTheProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTheProduct.Location = new System.Drawing.Point(619, 387);
            this.btnAddTheProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTheProduct.MaximumSize = new System.Drawing.Size(112, 32);
            this.btnAddTheProduct.MinimumSize = new System.Drawing.Size(112, 32);
            this.btnAddTheProduct.Name = "btnAddTheProduct";
            this.btnAddTheProduct.Size = new System.Drawing.Size(112, 32);
            this.btnAddTheProduct.TabIndex = 7;
            this.btnAddTheProduct.Text = "Add";
            this.btnAddTheProduct.UseVisualStyleBackColor = true;
            // 
            // ListofProducts2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddTheProduct);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataloadwindow);
            this.Name = "ListofProducts2";
            this.Text = "ListofProducts2";
            this.Load += new System.EventHandler(this.ListofProducts2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataloadwindow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataloadwindow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddTheProduct;
    }
}