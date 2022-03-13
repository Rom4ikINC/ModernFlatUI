using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ModernFlatUI.ProductList;
using static ModernFlatUI.DefineTheProduct;
using static ModernFlatUI.Form1;
using static ModernFlatUI.Reports;

namespace ModernFlatUI
{
    public partial class MainForm : Form
    {
        private readonly Form _frmDefineTheProduct = new DefineTheProduct() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
        private readonly Form _frmProductList = new ProductList() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private readonly Form _frmCashRegisterSystem = new Form1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private readonly Form _frmReports = new Reports() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };


        internal static MainForm Mainform;

        public MainForm()
        {
            this.Icon = Properties.Resources.cash_register_icon_157312;
            InitializeComponent();
            Mainform = this;
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            pnlProductMaintenance.Visible = false;
            pnlReports.Visible = false;
        }

        public void HideSubMenu()
        {
            if (pnlProductMaintenance.Visible == true)
                pnlProductMaintenance.Visible = false;
            if (pnlReports.Visible == true)
                pnlReports.Visible = false;
        }

        private void ShowSubMenu(Control subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        public void ShowFormDefineTheProduct()
        {
            pnlMain.Controls.Add(_frmDefineTheProduct);
            _frmDefineTheProduct.Show();
        }

        public void ShowFormReports()
        {
            pnlMain.Controls.Add(_frmReports);
            _frmReports.Show();
        }


        public void ShowFormProductList()
        {

            pnlMain.Controls.Add(_frmProductList);
            _frmProductList.Show();
        }

        public void ShowFormCashRegisterSystem()
        {
            pnlMain.Controls.Add(_frmCashRegisterSystem);
            _frmCashRegisterSystem.Show();
        }

        private void RefreshCashRegisterSystemFromTheStart()
        {
            if (FrmForm1.a != 0)
            {
                FrmForm1.button3.Text = @"REFRESH";
            }

            FrmForm1.table?.Clear();
            if (!File.Exists(@"OldProductList.txt"))
            {
                using (var sw = File.CreateText(@"OldProductList.txt"))
                {

                }
            }
            var exceptlines = File.ReadAllLines(@"OldProductList.txt");
            string[] exceptvalues;

            for (var i = 0; i < exceptlines.Length; i++)
            {

                exceptvalues = exceptlines[i].Split('/');
                var intexval = 0;

                for (var j = 0; j < exceptvalues.Length; j++)
                {
                    var exceptionvalue = exceptvalues[2];

                    var exceptbool = string.Equals(exceptionvalue, FrmForm1.exceptword, StringComparison.InvariantCulture);
                    if (exceptbool)
                    {

                    }
                    else
                    {
                        intexval = int.Parse(exceptionvalue);
                    }

                    if (intexval > 0) continue;
                    exceptvalues[2] = "Not Availabale";
                    var exceptresult = string.Join("/", exceptvalues);

                    exceptlines[i] = exceptresult;
                    File.WriteAllText(@"OldProductList.txt", string.Join("\n", exceptlines));
                }
            }

            var lines = File.ReadAllLines(@"OldProductList.txt");
            string[] values;

            foreach (var line in lines)
            {
                values = line.Split('/');
                var row = new object[values.Length];

                for (var j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }

                //FrmForm1.table?.Rows.Add(row);
                FrmForm1.a++;
            }
        }

        #region Reports
        private void btnReports_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlReports);
        }

        private void btnTotalSalesReport_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            pnlMain.Controls.Clear();
            //FrmReports.txtbStartDate.Enabled = true;
            //FrmReports.txtbEndDate.Enabled = true;
            //FrmReports.txtbStartDate.Text = "";
            //FrmReports.txtbEndDate.Text = "";
            FrmReports.rtxtbReportContent.Text = "";
            FrmReports.btnTop10Products.Enabled = true;
            FrmReports.btnMakeTheReport.Enabled = true;
            
            ShowFormReports();
        }

        private void btnTenMostSoldItems_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            pnlMain.Controls.Clear();
            //FrmReports.txtbStartDate.Enabled = false;
            //FrmReports.txtbEndDate.Enabled = false;
            //FrmReports.txtbStartDate.Text = "";
            //FrmReports.txtbEndDate.Text = "";
            FrmReports.rtxtbReportContent.Text = "";
            FrmReports.btnTop10Products.Enabled = false;
            FrmReports.btnMakeTheReport.Enabled = false;
            FrmReports.GetTop10();

            ShowFormReports();

        }
        #endregion

        #region ProductMaintenance
        private void btnDefineTheProduct_Click(object sender, EventArgs e)
        {
           /* FrmDefineTheProduct.txtbPrice.ForeColor = Color.Black;
            FrmDefineTheProduct.txtbPrice.BackColor = Color.White;
            FrmDefineTheProduct.txtbPrice.Text = "0";*/
            HideSubMenu();
            FrmDefineTheProduct.ClearTheInfoInDefineTheProduct();
            FrmDefineTheProduct.btnAddTheProduct.Enabled = false;
            FrmDefineTheProduct.btnChangeTheProductInfo.Enabled = false;
            pnlMain.Controls.Clear(); 
            ShowFormDefineTheProduct(); 
        }

        private void btnListOfProducts_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            pnlMain.Controls.Clear();
            FrmProductList.products.Clear();
            FrmProductList.GetTheProductInfo();
            FrmProductList.dgvProductList.Rows.Clear();
            for (var i = 0; i < FrmProductList.products.Count; i++)
            {
                FrmProductList.dgvProductList.Rows.Add(FrmProductList.products[i].Name, FrmProductList.products[i].Price, FrmProductList.products[i].Quantity, FrmProductList.products[i].Description);
            }
            ShowFormProductList(); 
        }

        private void btnProductMaintenance_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlProductMaintenance);
        }
        #endregion

        private void btnCashRegister_Click(object sender, EventArgs e)
        {

            /*if (File.ReadAllLines(@"OldProductList.txt").Length == 0)
            {
                MessageBox.Show(@"Please, define the product first!");
            }*/
            
            {
                HideSubMenu();
                pnlMain.Controls.Clear();
                RefreshCashRegisterSystemFromTheStart();
                //FrmForm1.button3.Enabled = File.ReadAllLines(@"OldProductList.txt").Length != 0;
                if (FrmForm1.txtName.Text == "")
                    FrmForm1.textBox1.ReadOnly = true;
                ShowFormCashRegisterSystem();
            }

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@"OldProductList.txt"))
            {
                using (var sw = File.CreateText(@"OldProductList.txt"))
                {

                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Create("ram.txt").Close();

        }
    }
}
