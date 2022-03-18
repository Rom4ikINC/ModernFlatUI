using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernFlatUI
{
    public partial class Reports : Form
    {
        static string myConnectionString = "server=localhost;user id=root;pwd=221102;sslmode=None;database=productlist";

        internal static Reports FrmReports;

        public Reports()
        {
            InitializeComponent();
            FrmReports = this;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }   

        private void btnMakeTheReport_Click(object sender, EventArgs e)
        {

            int total = 0;
            var startDate = dtpStartDate.Text;
            var endDate = dtpEndDate.Text;

            MySqlConnection conn = new MySqlConnection();
            MySqlCommand selectCommand;
            MySqlDataReader dataReader;

            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                string querySelect = @"SELECT COUNT(ORDERID) FROM totalandtime; SELECT SUM(TOTAL) FROM totalandtime WHERE created_at BETWEEN '" 
                                     + startDate + "' AND '" + endDate + "';";
                selectCommand = new MySqlCommand(querySelect, conn);
                dataReader = selectCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    if (dataReader.GetInt32(0) == 0)
                    {
                        MessageBox.Show("Please, make the purchase first!");
                        return;
                    }
                }

                dataReader.NextResult();
                while (dataReader.Read())
                {
                    total = dataReader.GetInt32(0);
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            rtxtbReportContent.Text = "Total sales report:\n" + total.ToString() + "€";



            btnMakeTheReport.Enabled = false;
            btnTop10Products.Enabled = false;
        }

        public int[] GetTop10()
        {
            int[] products;
            int quantityOfProducts = 0;
            var startDate = dtpStartDate.Text;
            var endDate = dtpEndDate.Text;

            MySqlConnection conn = new MySqlConnection();
            MySqlCommand selectCommand;
            MySqlDataReader dataReader;
            
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                string querySelect = @"SELECT COUNT(PRODUCTID) FROM productlistdata; SELECT pl.PRODUCTID, SUM(r.AMOUNT) FROM receipts r INNER JOIN productlistdata pl ON pl.NAME = r.NAME "
                    + "INNER JOIN totalandtime tat ON tat.ORDERID = r.ORDERID WHERE tat.created_at BETWEEN '" + startDate + "' AND '" + endDate + "' GROUP BY pl.PRODUCTID; ";
                selectCommand = new MySqlCommand(querySelect, conn);
                dataReader = selectCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    quantityOfProducts = dataReader.GetInt32(0);
                }
                products = new int[quantityOfProducts];

                dataReader.NextResult();

                while (dataReader.Read())
                {
                    products[dataReader.GetInt32(0) - 1] += dataReader.GetInt32(1);
                }
                return products;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public string[] GetProductsNames()
        {
            MySqlConnection conn = new MySqlConnection();
            MySqlCommand selectCommand;
            MySqlDataReader dataReader;
            string[] productsNames;
            int quantityOfProducts = 0;
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();
                string querySelect = @"SELECT COUNT(PRODUCTID) FROM productlistdata; SELECT PRODUCTID, NAME FROM productlistdata;";
                selectCommand = new MySqlCommand(querySelect, conn);
                dataReader = selectCommand.ExecuteReader();

                while (dataReader.Read())
                {
                quantityOfProducts = dataReader.GetInt32(0);
                }
                productsNames = new string[quantityOfProducts];

                dataReader.NextResult();

                while (dataReader.Read())
                {
                    int id = dataReader.GetInt32(0);
                    productsNames[id - 1] = dataReader.GetString(1);
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

            return productsNames;
        }

        private void btnTop10Products_Click(object sender, EventArgs e)
        {
            string unsorterTop10 = "";
            int[] top10Array = GetTop10();
            string[] productsNames = GetProductsNames();

            // creates a string like "Americano-34\nMocha-111..."
            for (int i = 0; i < productsNames.Length; i++)
            {
                if (top10Array[i] != 0 && i != productsNames.Length - 1)
                {
                    unsorterTop10 = unsorterTop10 + productsNames[i] + "-" + top10Array[i].ToString() + "\n"; 
                }
                else if (top10Array[i] != 0)
                {
                    unsorterTop10 = unsorterTop10 + productsNames[i] + "-" + top10Array[i].ToString();

                }
            }
            string[] top10 = unsorterTop10.Split('\n');

            // bubble sort to make top10
            string temp;
            for (int j = 0; j <= top10.Length - 2; j++)
            {
                for (int i = 0; i <= top10.Length - 2; i++)
                {
                    if (int.Parse(top10[i].Split('-')[1]) < int.Parse(top10[i + 1].Split('-')[1])) // e.g. Mocha-3 and Americano-4  if(3 > 4)
                    {
                        temp = top10[i + 1];
                        top10[i + 1] = top10[i];
                        top10[i] = temp;
                    }
                }
            }
            rtxtbReportContent.Text = String.Join("\n", top10);
            btnTop10Products.Enabled = false;
            btnMakeTheReport.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //txtbStartDate.Text = "";
            //txtbStartDate.Enabled = true;
            //txtbEndDate.Text = "";
            //txtbEndDate.Enabled = true;
            btnTop10Products.Enabled = true;
            rtxtbReportContent.Text = "";
            btnMakeTheReport.Enabled = true;
        }

        private void txtbStartDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
