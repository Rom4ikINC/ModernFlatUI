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

        static string myConnectionString = "server=localhost;user id=root;pwd=Romaska14;sslmode=None;database=productlist";

        public static string PathTop10ProductsFile = Environment.CurrentDirectory + "\\Reports\\Top10\\Top10Products.txt";

        internal static Form1 FrmForm1;

        public Form1()
        {
            InitializeComponent();
            FrmForm1 = this;
        }
        int fakevar;
        double totalsum;
        double total1st;
        double total2st;
        public int a = 1;
        string b = "";
        double fulltotal;
        public string exceptword = "Not Availabale";

        public DataTable table = new DataTable();
        readonly DataTable ordertable = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@"ram.txt"))
            {
                using (var sw = File.CreateText(@"ram.txt"))
                {
                    fakevar = 2;
                }
            }

            FormClosing += Form1_Closing;
            button1.Click += button1_Click;

            table.Columns.AddRange(new DataColumn[4] { new DataColumn("Name", typeof(string)),
                        new DataColumn("Price", typeof(string)),
                        new DataColumn("Amount",typeof(string)),
                        new DataColumn("Description", typeof(string))});

            dataEditWindow.DataSource = table;
            dataEditWindow.DataSource = table;
            dataEditWindow.AllowUserToAddRows = false;
            dataEditWindow.Columns["Description"].Visible = false;

            ordertable.Columns.AddRange(new DataColumn[4] { new DataColumn("Name", typeof(string)),
                        new DataColumn("Price", typeof(string)),
                        new DataColumn("Amount", typeof(string)),
                        new DataColumn("RowNum", typeof(string))});
            dataOrderWindow.DataSource = ordertable;
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

            button1.Enabled = new FileInfo(Environment.CurrentDirectory + "\\ram.txt").Length != 0;

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






            /*var exceptlines = File.ReadAllLines(@"OldProductList.txt");
            string[] exceptvalues;
            
            for(var i = 0; i < exceptlines.Length; i++)
            {

                exceptvalues = exceptlines[i].Split('/');
                var intexval = 0;

                for (var j = 0; j < exceptvalues.Length; j++)
                {
                    var exceptionvalue = exceptvalues[2];
                    
                    var exceptbool = string.Equals(exceptionvalue, exceptword, StringComparison.InvariantCulture);
                    if (exceptbool)
                    {

                    } else { 
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
                var row = new string[values.Length];

                for (var j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }

                table?.Rows.Add(row);
                a++;
            }*/




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
                button1.Enabled = new FileInfo(Environment.CurrentDirectory + "\\ram.txt").Length != 0;
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
        }



        private void label4_Click(object sender, EventArgs e)
        {

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

        private void label7_Click(object sender, EventArgs e)
        {

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
            var columnIndexR = dataEditWindow.CurrentCell.ColumnIndex;
            var rowIndexR = dataEditWindow.CurrentCell.RowIndex;


            ordertable?.Clear();
            const string fileName = @"ram.txt";
            if (!File.Exists(fileName))
            {
                using (var sw = File.CreateText(fileName))
                {
                    fakevar = 2;
                }
            }
            var Path = Environment.CurrentDirectory + "\\ram.txt";
            using (var OrderList = File.AppendText(fileName))
            {
                OrderList.WriteLine(GetTheOrder());
            }

            var lines2 = File.ReadAllLines(@"ram.txt");

            foreach (var line in lines2)
            {
                var values2 = line.Split('/');
                var row = new string[values2.Length];

                for (var j = 0; j < values2.Length; j++)
                {
                    row[j] = values2[j].Trim();
                }
                ordertable.Rows.Add(row);
                a++;
            }

            fulltotal += totalsum;
            FullTotal.Text = $"{fulltotal}";
            textBox1.Clear();
            total.Text = "0";

            button1.Enabled = new FileInfo(@"ram.txt").Length != 0;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"ram.txt", string.Empty);
            ordertable?.Clear();
            fulltotal = 0;
            FullTotal.Clear();
            button1.Enabled = new FileInfo(@"ram.txt").Length != 0;
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
            while (true)
            {
                const string dir = @"Receipts";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                    continue;
                }

                var nameofthefile = dir + "\\" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss", new CultureInfo("en-US")) + ".txt";
                using (TextWriter tw = new StreamWriter(nameofthefile))
                {
                    var grandtotal = "Total: " + FullTotal.Text; 
                    //var idOfTheFile = Directory.GetFiles(dir).Length;
                    tw.WriteLine(grandtotal);
                    //tw.WriteLine(idOfTheFile);
                    const string instruction = "The information below is NAME | PRICE | AMOUNT | ID NUMBER IN THE TABLE";
                    tw.WriteLine(instruction);
                    for (var i = 0; i < dataOrderWindow.Rows.Count; i++)
                    {
                        for (var j = 0; j < dataOrderWindow.Columns.Count; j++)
                        {
                            tw.Write($"{dataOrderWindow.Rows[i].Cells[j].Value}");

                            if (j != dataOrderWindow.Columns.Count - 1)
                            {
                                tw.Write("/");
                            }
                        }

                        tw.WriteLine();
                    }
                }

                var orderListFileLines = File.ReadAllLines(@"ram.txt");
                const string pathOldProductFile = @"OldProductList.txt";
                const string pathNewProductFile = @"NewProductList.txt";

                File.Copy(pathOldProductFile, pathNewProductFile, true);

                if (fakevar != 1)
                {
                    for (var i = 0; i <= orderListFileLines.Length - 1; i++)
                    {
                        var orderListFileValues = orderListFileLines[i].Split('/');
                        var currentamount = orderListFileValues[2];
                        var currentstringId = orderListFileValues[3];

                        var id = int.Parse(currentstringId);

                        var pathNewProductFileLines = File.ReadAllLines(@"NewProductList.txt");

                        var pathNewProductFileValues = pathNewProductFileLines[id].Split('/');
                        var oldamount = pathNewProductFileValues[2];
                        var intoldamount = int.Parse(oldamount);
                        var intcurrentamount = int.Parse(currentamount);
                        var inttotal = intoldamount - intcurrentamount;

                        pathNewProductFileValues[2] = inttotal.ToString();

                        var result = string.Join("/", pathNewProductFileValues);

                        pathNewProductFileLines[id] = result;
                        File.WriteAllText(@"NewProductList.txt", string.Join("\n", pathNewProductFileLines));
                    }
                }

                if (fakevar != 1)
                    AddToTop10Products();

                File.Copy(pathNewProductFile, pathOldProductFile, true);
                fakevar++;
                if (fakevar == 2)
                {
                    fakevar = 0;
                    ordertable?.Clear();
                    fulltotal = 0;
                    FullTotal.Clear();
                    button4_Click(sender, e);
                }

                button3_Click(sender, e);

                break;
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
