using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ModernFlatUI
{
    public partial class Form1 : Form
    {

        static string myConnectionString = "server=localhost;user id=root;pwd=221102;sslmode=None;database=productlist";
        

        public static string PathTop10ProductsFile = Environment.CurrentDirectory + "\\Reports\\Top10\\Top10Products.txt";

        internal static Form1 FrmForm1;

        public Form1()
        {
            InitializeComponent();
            FrmForm1 = this;
        }
        int fakevar;
        int clonedoubleavoid = 0;
        double totalsum;
        double total1st;
        double total2st;
        string b = "";
        //public int WHATAREYOU = 1;
        double fulltotal;
        public string exceptword = "Not Availabale";



        public DataTable table = new DataTable();
        readonly DataTable ordertable = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {

            FormClosing += Form1_Closing;
            button1.Click += button1_Click;

            table.Columns.AddRange(new DataColumn[4] { new DataColumn("Name", typeof(string)),
                        new DataColumn("Price", typeof(string)),
                        new DataColumn("Amount",typeof(string)),
                        new DataColumn("Description", typeof(string))});

            dataEditWindow.DataSource = table;
            dataEditWindow.AllowUserToAddRows = false;
            dataEditWindow.Columns["Description"].Visible = false;

            ordertable.Columns.AddRange(new DataColumn[4] { new DataColumn("Name", typeof(string)),
                        new DataColumn("Price", typeof(string)),
                        new DataColumn("Amount", typeof(string)),
                        new DataColumn("RowNum", typeof(string))});
            dataOrderWindow.DataSource = ordertable;
            dataOrderWindow.AllowUserToAddRows = false;

            dataOrderWindow.Columns["RowNum"].Visible = false;

            foreach (DataGridViewColumn col in dataEditWindow.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn col in dataOrderWindow.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            button1.Enabled = false;

        }

        public void button3_Click(object sender, EventArgs e)
        {
            /*if(a != 0)
            {
                button3.Text = @"REFRESH";
            }*/

            table?.Clear();

            MySql.Data.MySqlClient.MySqlConnection conn;
            conn = new MySql.Data.MySqlClient.MySqlConnection();

            try
            {
                //downloading data for the first time from the main db
                conn.ConnectionString = myConnectionString;
                conn.Open();
                string sql = "SELECT NAME, PRICE, AMOUNT FROM productlistdata ";
                MySqlDataAdapter da = new MySqlDataAdapter();

                da.SelectCommand = new MySqlCommand(sql, conn);

                DataTable table = new DataTable();
                da.Fill(table);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;

                dataEditWindow.DataSource = bSource;
         

            } catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            txtName.Text = dataEditWindow.Rows[0].Cells[0].Value.ToString();
            txtAmount.Text = dataEditWindow.Rows[0].Cells[2].Value.ToString();
            txtPrice.Text = dataEditWindow.Rows[0].Cells[1].Value.ToString();
            if (txtName.Text != null)
            {
                textBox1.ReadOnly = false;
            }

            button2.Enabled = false;
            textBox1.Text = "";

        }

        private void dataEditWindow_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            textBox1.Enabled = true;
            /*button2.Enabled = true;*/
            var row = dataEditWindow.Rows[e.RowIndex];
            txtName.Text = row.Cells[0].Value.ToString();
            b = row.Cells[1].Value.ToString();
            txtPrice.Text = row.Cells[1].Value.ToString();
            txtAmount.Text = row.Cells[2].Value.ToString();
            
            var cmcExCheck = string.Equals(exceptword, txtAmount.Text, StringComparison.InvariantCulture);
            if (cmcExCheck)
            {
                textBox1.Enabled = false;
                button2.Enabled = false;
                button1.Enabled = false;
            } else
            {
                button2.Enabled = true;
                button1.Enabled = true;
            }
            var totam = textBox1.Text;
            var b1 = string.IsNullOrEmpty(totam);
            if (b1)
            {
                total.Text = @"0";
                button2.Enabled = false;
            }
            else
            {
                total1st = int.Parse(textBox1.Text);
                total2st = double.Parse(txtPrice.Text);
                totalsum = total1st * total2st;
                total.Text =  $@"{totalsum}";
            }
            if (txtAmount.Text == "Not available")
            {
                textBox1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            if (dataOrderWindow.Rows.Count == 0)
            {
                button1.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            var totam = textBox1.Text;
            var b1 = string.IsNullOrEmpty(totam);
           
            if (b1)
            {
                total.Text = @"0";
                button2.Enabled = false;

            }
            else
            {
                int exzero1stvalue = totam.IndexOf('0');
                
                if (int.Parse(textBox1.Text) > int.Parse(txtAmount.Text))
                {
                    MessageBox.Show(@"Your value is out of the range of available items!");
                    button2.Enabled = false;
                }
                else 
                { if(exzero1stvalue == 0)
                    {
                        button2.Enabled = false;
                        button1.Enabled = false;
                    } else { 
                    button2.Enabled = true;
                    total1st = int.Parse(textBox1.Text);
                    total2st = double.Parse(txtPrice.Text); 
                    totalsum = total1st * total2st;
                    total.Text = $@"{totalsum}";
                    }
                }
            }

        }


        private void AddToTop10Products()
        {
            if (!File.Exists(PathTop10ProductsFile) || File.ReadAllLines(PathTop10ProductsFile).Length == 0)
            {
                using (var sw = File.CreateText(PathTop10ProductsFile))
                {
                    var sr = File.ReadAllLines(@"OldProductList.txt");
                    foreach (var line in sr)
                    {
                        sw.WriteLine(line.Split('/')[0] + '/' + '0');
                    }
                }
            }

            if (!File.Exists(@"ram.txt"))
            {
                using (var sw = File.CreateText(@"ram.txt"))
                {
                    fakevar = 2;
                }
            }

            var lineToEdit = 0; 
            for (var i = 0; i < dataOrderWindow.RowCount; i++)
            {
                var amountOfTheProduct = dataOrderWindow.Rows[i].Cells[2].Value.ToString();
                foreach (var line in File.ReadAllLines(PathTop10ProductsFile))
                {
                    var nameOfTheProductToCompare = line.Split('/')[0];
                    var amountOfTheProductInTop10 = line.Split('/')[1];
                    if (nameOfTheProductToCompare == dataOrderWindow.Rows[i].Cells[0].Value.ToString())
                    {
                        var lines = File.ReadAllLines(PathTop10ProductsFile);

                        using (var writer = new StreamWriter(PathTop10ProductsFile))
                        {
                            for (var currentLine = 0; currentLine < lines.Length; currentLine++)
                            {
                                if (currentLine == lineToEdit)
                                {
                                    writer.WriteLine(nameOfTheProductToCompare + '/' + (int.Parse(amountOfTheProductInTop10) + int.Parse(amountOfTheProduct)).ToString());
                                    lineToEdit = 0;
                                }
                                else
                                {
                                    writer.WriteLine(lines[currentLine]);
                                }
                            }
                        }
                    }
                    lineToEdit++;
                }

                lineToEdit = 0;
            }
        }


        private string GetTheOrder()
        {
            var order = txtName.Text + '/' + txtPrice.Text + '/' + textBox1.Text + '/' + dataEditWindow.CurrentCell.RowIndex;
            return order;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            MySql.Data.MySqlClient.MySqlConnection conn;
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            try
            {
                if (dataEditWindow.CurrentRow == null)
                    return;
                //coping data from the 1st datagridview
                foreach (DataGridViewRow row in dataEditWindow.SelectedRows)
                {
                    ((DataTable)dataOrderWindow.DataSource).ImportRow(((DataRowView)row.DataBoundItem).Row);

                }
                //changing the last cell value
                dataOrderWindow.Rows[dataOrderWindow.Rows.Count - 1].Cells[2].Value = textBox1.Text;

                //cloning db to tempdb
                conn.ConnectionString = myConnectionString;
                conn.Open();
                if (clonedoubleavoid == 0)
                {
                    
                    string querycleaning = "DELETE FROM productlistdataram;";
                    MySqlCommand clearingthetable = new MySqlCommand(querycleaning, conn);
                    clearingthetable.ExecuteNonQuery();

                    string queryclone = "INSERT INTO productlistdataram SELECT * FROM productlistdata;";
                    MySqlCommand clone = new MySqlCommand(queryclone, conn);
                    clone.ExecuteNonQuery();
                }

                //updating info
                int available = int.Parse(txtAmount.Text);
                int buying = int.Parse(textBox1.Text);
                string queryupdate;
                available = available - buying;
                if(available == 0)
                {
                    queryupdate = $"UPDATE productlistdataram SET AMOUNT='Not available' WHERE NAME = '" + txtName.Text + "';";
                } else
                {
                    queryupdate = $"UPDATE productlistdataram SET AMOUNT='" + available + "' WHERE NAME = '" + txtName.Text + "';";
                }
                
                MySqlCommand updatedata = new MySqlCommand(queryupdate, conn);
                updatedata.ExecuteNonQuery();

                //downloading new data from productlistdataram table to dataEditWindow
                table?.Clear();

                string sqlload = "SELECT NAME, PRICE, AMOUNT FROM productlistdataram ";
                MySqlDataAdapter da = new MySqlDataAdapter();

                da.SelectCommand = new MySqlCommand(sqlload, conn);

                DataTable table1 = new DataTable();
                da.Fill(table1);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = table1;

                dataEditWindow.DataSource = bSource;



            } catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            clonedoubleavoid++;
            button3.Enabled = false;
            txtAmount.Clear();
            textBox1.Enabled = false;

            fulltotal += totalsum;
            FullTotal.Text = $"{fulltotal}";
            textBox1.Clear();
            total.Text = "0";

            button1.Enabled = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clonedoubleavoid = 0;
            File.WriteAllText(@"ram.txt", string.Empty);
            ordertable?.Clear();
            fulltotal = 0;
            FullTotal.Clear();
            button1.Enabled = false;
            button3.Enabled = true;
            button3.PerformClick();
        }

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "My Application", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            } else
            {
                File.WriteAllText(@"ram.txt", string.Empty);
                ordertable?.Clear();
                fulltotal = 0;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fakevar != 1)
            {

                
                MySql.Data.MySqlClient.MySqlConnection conn;
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                int maxid = 0;
                try
                {
                    conn.ConnectionString = myConnectionString;
                    conn.Open();
                    //receiving the max id from db
                    string querymaxid = "SELECT COALESCE(MAX(ORDERID), 0)FROM receipts;";
                    MySqlCommand command = new MySqlCommand(querymaxid, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        maxid = reader.GetInt32(0);
                        reader.Close();

                    }
                    maxid++;//id that is used in db
                    for (int i = 0; i < dataOrderWindow.Rows.Count; i++)
                    {
                        string pricedecimal = $"" + dataOrderWindow.Rows[i].Cells[1].Value;
                        pricedecimal = pricedecimal.Replace(',', '.');
                        string querysendingData = $"INSERT INTO receipts (ORDERID, NAME, PRICE, AMOUNT)VALUES(" + maxid + ", '" + dataOrderWindow.Rows[i].Cells[0].Value + "', " + pricedecimal + ", '" + dataOrderWindow.Rows[i].Cells[2].Value + "');";

                        MySqlCommand sendingData = new MySqlCommand(querysendingData, conn);
                        sendingData.ExecuteNonQuery();
                    }

                    //sending dataandtime and total to db
                    string fulltotaldecimal = $"" + FullTotal.Text;
                    fulltotaldecimal = fulltotaldecimal.Replace(',', '.');
                    string querytotal = $"INSERT INTO totalandtime (ORDERID, TOTAL, created_at)VALUES(" + maxid + ", '" + fulltotaldecimal + "', NOW());";
                    MySqlCommand sendtotal = new MySqlCommand(querytotal, conn);
                    sendtotal.ExecuteNonQuery();//to finish the send method

                    //next step is to apply the changes from ram to main db
                    string querymaincleaning = "DELETE FROM productlistdata;";
                    MySqlCommand mainclearingthetable = new MySqlCommand(querymaincleaning, conn);
                    mainclearingthetable.ExecuteNonQuery();
                    string querymainclone = "INSERT INTO productlistdata SELECT * FROM productlistdataram;";
                    MySqlCommand mainclone = new MySqlCommand(querymainclone, conn);
                    mainclone.ExecuteNonQuery();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }

            

            //fakevar to prevent double start of the function
            fakevar++;
            if (fakevar == 2)
            {
                fakevar = 0;
                ordertable?.Clear();
                fulltotal = 0;
                FullTotal.Clear();
                button4_Click(sender, e);
                clonedoubleavoid = 0;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //Checking if only number and delete.
            {
                e.Handled = true;
            }
            string exzero = textBox1.Text;
            var extrue = string.IsNullOrEmpty(exzero);
            if (extrue)
            {

            }
            else
            {
                int exzero1stvalue = exzero.IndexOf('0');
                if (exzero1stvalue == 0)
                {
                    button2.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                }
            }
        }

        private void dataEditWindow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataOrderWindow_SelectionChanged(object sender, EventArgs e)
        {
            dataOrderWindow.ClearSelection();
        }
    }
}
