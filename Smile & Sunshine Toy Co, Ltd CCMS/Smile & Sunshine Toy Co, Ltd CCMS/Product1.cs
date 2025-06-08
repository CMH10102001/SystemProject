using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Smile___Sunshine_Toy_Co__Ltd_CCMS
{
    public partial class Product1 : Form
    {
        private DataTable dt = new DataTable();
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;"
                        + "Data Source=Database1.accdb";
        private void UpdateGrid(string sqlStr)
        {
            OleDbDataAdapter dataAdapter =
                        new OleDbDataAdapter(sqlStr, connStr);
            dt.Clear();
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();
            dataGridView1.DataSource = dt;
        }
        public Product1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'database1DataSet1.Product' 資料表。您可以視需要進行移動或移除。
            this.productTableAdapter.Fill(this.database1DataSet1.Product);
            dataGridView1.ReadOnly = true;
            if (lblText.Text == "1")
            {
                bt1.Visible = false;
            }
            UpdateGrid("Select * from Product");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Companies frm = new Companies();
            frm.ShowDialog();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Employee1 frm = new Employee1();
            frm.ShowDialog();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (lblText.Text != "1")
            {
                int a = int.Parse(lblText.Text);
                a--;
                lblText.Text = a.ToString();
                lbl1.Text = "Showing the staff of " + lblText.Text;
            }
            if (lblText.Text == "1")
            {
                bt1.Visible = false;
            }
        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void bt2_Click(object sender, EventArgs e)
        {
            String a = lblText.Text;
            int b = int.Parse(a);
            b++;
            lblText.Text = b.ToString();
            if (lblText.Text != "1")
            {
                bt1.Visible = true;
            }
            lbl1.Text = "Showing the staff of " + lblText.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product2 frm = new Product2();
            frm.ShowDialog();
        }
    }
}
