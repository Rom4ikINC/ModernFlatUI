using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static ModernFlatUI.ProductList;

namespace ModernFlatUI
{
   
    public partial class DefineTheProduct : Form
    {

        public string Path = Environment.CurrentDirectory + "\\OldProductList.txt";
        public string TempPath = Environment.CurrentDirectory + "\\TempFile.txt";

        internal static DefineTheProduct FrmDefineTheProduct;

        public DefineTheProduct()
        {
            InitializeComponent();
            FrmDefineTheProduct = this;
        }

        private string GetTheProduct()
        {
            
            var productInfo =  txtbName.Text + '/' +  txtbPrice.Text  + '/' + nudQuantity.Text + '/' + txtbDescription.Text.Replace("\r", string.Empty).Replace("\n", @"\n");
            return productInfo;
        }
        public void ClearTheInfoInDefineTheProduct()
        {
            txtbName.Text = @"Name";
            txtbPrice.Text = @"0";
            nudQuantity.Value = 0;
            txtbDescription.Text = @"Description";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddTheProduct_Click(object sender, EventArgs e)
        {
            using (var productsList = File.AppendText(Path))
            {
                productsList.WriteLine(GetTheProduct());
            }
            ProductList.FrmProductList.RefreshGrid();
            
        }

        private void DefineTheProduct_Load(object sender, EventArgs e)
        {
            txtbPrice.ForeColor = Color.Black;
            txtbPrice.BackColor = Color.White;
            //txtbPrice.Text = "0";
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            MainForm.Mainform.pnlMain.Controls.Clear();
            if (FrmProductList.dgvProductList.Rows.Count == 1)
            {
                FrmProductList.products.Clear();
            

            FrmProductList.GetTheProductInfo();
            for (var i = 0; i < FrmProductList.products.Count; i++)
            {
                FrmProductList.dgvProductList.Rows.Add(FrmProductList.products[i].Name, FrmProductList.products[i].Price, FrmProductList.products[i].Quantity,
                    FrmProductList.products[i].Description);
            }

            FrmProductList.dgvProductList.Refresh();
            }
       
            MainForm.Mainform.ShowFormProductList();
            
        }

        private void btnChangeTheProductInfo_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Path))
            {
                using (var sw = File.CreateText(Path))
                {

                }
            }

            if (!File.Exists(TempPath))
            {
                using (var sw = File.CreateText(TempPath))
                {

                }
            }

            var rowIndex = FrmProductList.dgvProductList.CurrentCell.RowIndex;

            FrmProductList.products[rowIndex] =
                new Product(txtbName.Text, txtbPrice.Text, nudQuantity.Text, txtbDescription.Text.Replace("\r", string.Empty).Replace("\n", @"\n"));


            var newLine = FrmProductList.products[rowIndex];
            var lineToWrite = newLine.Name + '/' + newLine.Price + '/' + newLine.Quantity + '/' + newLine.Description;
            var lineNumber = 0;
            using (var reader = new StreamReader(Path))
            using (var writer = new StreamWriter(TempPath))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(lineNumber == rowIndex ? lineToWrite : line);
                    lineNumber++;
                }
            }
            var arrLine = File.ReadAllLines(TempPath);
            File.WriteAllLines(Path, arrLine);
            FrmProductList.dgvProductList.Rows.RemoveAt(rowIndex);
            FrmProductList.dgvProductList.Rows.Insert(rowIndex, newLine.Name, newLine.Price, newLine.Quantity, newLine.Description);
            FrmProductList.dgvProductList.Rows[rowIndex].Selected = true;
        }

        private void txtbName_Click(object sender, EventArgs e)
        {
            if (txtbName.Text == @"Name")
                txtbName.SelectAll();
        }

        private void txtbPrice_Click(object sender, EventArgs e)
        {
            if (txtbPrice.Text == @"0")
                txtbPrice.SelectAll();
        }

        private void txtbDescription_Click(object sender, EventArgs e)
        {
            if (txtbDescription.Text == @"Description")
                txtbDescription.SelectAll();
        }

        string oldTextName = string.Empty;
        string oldTextPrice = "0";

        private void txtbName_TextChanged(object sender, EventArgs e)
        {
            /*if (System.Text.RegularExpressions.Regex.IsMatch(txtbName.Text, "^[a-aA-Z ]")) return;
            MessageBox.Show(@"This field accepts only alphabetical characters!");
            txtbName.Text.Remove(txtbName.Text.Length - 1);*/

            if (txtbName.Text.All(chr => char.IsLetterOrDigit(chr) || chr == '-' || chr == ' '))
            {
                oldTextName = txtbName.Text;
                txtbName.Text = oldTextName;

                txtbName.BackColor = System.Drawing.Color.White;
                txtbName.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                txtbName.Text = oldTextName;
                txtbName.BackColor = System.Drawing.Color.Red;
                txtbName.ForeColor = System.Drawing.Color.White;
            }
            txtbName.SelectionStart = txtbName.Text.Length;
        }

        private void txtbPrice_TextChanged(object sender, EventArgs e)
        {
            btnAddTheProduct.Enabled = true;
            if (txtbPrice.Text == @"" || txtbPrice.Text == @"0" )
                btnAddTheProduct.Enabled = false;

            txtbPrice.ForeColor = Color.Black;
            txtbPrice.BackColor = Color.White;

            if (txtbPrice.Text.All(chr => char.IsNumber(chr)) && txtbPrice.Text == @"01" || txtbPrice.Text == @"00" || txtbPrice.Text == @"02" || txtbPrice.Text == @"03" || txtbPrice.Text == @"04" || txtbPrice.Text == @"05" || txtbPrice.Text == @"06" || txtbPrice.Text == @"07" || txtbPrice.Text == @"08" || txtbPrice.Text == @"09")
                txtbPrice.Text = txtbPrice.Text.Remove(txtbPrice.Text.Length - 1);
            if (txtbPrice.Text.All(chr => char.IsNumber(chr) || chr == '.')) return;

            //MessageBox.Show("This textbox accepts only alphabetical characters");
            txtbPrice.Text = txtbPrice.Text.Remove(txtbPrice.Text.Length - 1);
            txtbPrice.SelectionStart = txtbPrice.Text.Length;
            txtbPrice.SelectionLength = 0;
            txtbPrice.BackColor = Color.Red;
            txtbPrice.ForeColor = Color.White;

            /*System.Text.RegularExpressions.Regex.IsMatch(txtbPrice.Text, "^[0-9 ]"*/
            /* if (txtbPrice.Text.All(chr => char.IsNumber(chr)))
             {
                 oldTextPrice = txtbPrice.Text;
                 txtbPrice.Text = oldTextPrice;

                 txtbPrice.BackColor = Color.White;
                 txtbPrice.ForeColor = Color.Black;
             }
             else
             {
                 txtbPrice.Text = oldTextPrice;
                 txtbPrice.BackColor = Color.Red;
                 txtbPrice.ForeColor = Color.White;
             }
             txtbPrice.SelectionStart = txtbPrice.Text.Length;*/
        }
    }
}
