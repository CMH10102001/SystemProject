using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.OleDb;

namespace Smile___Sunshine_Toy_Co__Ltd_CCMS
{
    public partial class Product2 : Form
    {
        private DataTable dt = new DataTable();
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;"
                        + "Data Source=Database1.accdb";
        public Product2()
        {
            InitializeComponent();
        }

        private void label15_AutoSizeChanged(object sender, EventArgs e)
        {

        }
        private void UpdateGrid(string sqlStr)
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
            dt.Clear();
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();
            dataGridView1.DataSource = dt;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'database1DataSet1.Product' 資料表。您可以視需要進行移動或移除。
            this.productTableAdapter.Fill(this.database1DataSet1.Product);

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (bookIDTextBox.Text != "" && titleTextBox.Text != "" && authorTextBox.Text != "" && publisherTextBox.Text != "" && textBox1.Text != "" && textBox2.Text != "")
                {
                    UpdateGrid("Insert into Product values (\"" + bookIDTextBox.Text + "\",\"" + titleTextBox.Text + "\"," + int.Parse(authorTextBox.Text) + ",\"" + publisherTextBox.Text + "\",\"" + textBox2.Text + "\",\"" + textBox3.Text + "\");");
                    UpdateGrid("Select * from Product");
                }
                else if (textBox3.Text == "")
                {
                    UpdateGrid("Insert into Product values (\"" + bookIDTextBox.Text + "\",\"" + titleTextBox.Text + "\"," + int.Parse(authorTextBox.Text) + ",\"" + publisherTextBox.Text + "\",\"" + textBox2.Text + "\"," + null + ");");
                    UpdateGrid("Select * from Product");
                }
                else
                    MessageBox.Show("Please enter all of message");
            }
            catch (Exception E)
            {
                MessageBox.Show("Error enter! ");
            }
        }

        private void bookIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void authorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void publisherTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox7.Text == "")
                {
                    MessageBox.Show("Cannot be empty! ");
                }
                else
                {
                    UpdateGrid("Delete from Product where Product_Id = \"" + textBox7.Text + "\";");
                    UpdateGrid("Select * from Product");
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Invalid value !");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Companies1 frm = new Companies1();
            frm.ShowDialog();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Employee1 frm = new Employee1();
            frm.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
