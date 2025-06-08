using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Smile___Sunshine_Toy_Co__Ltd_CCMS
{
    public partial class Employee2 : Form
    {

        private DataTable dt = new DataTable();
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;"
                        + "Data Source=Database1.accdb";
        public Employee2()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee1 frm = new Employee1();
            frm.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Companies frm = new Companies();
            frm.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Product1 frm = new Product1();
            frm.ShowDialog();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            Employee1 frm = new Employee1();
            frm.ShowDialog();
        }

        private void Employee2_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'database1DataSet1.Employee' 資料表。您可以視需要進行移動或移除。
            this.employeeTableAdapter.Fill(this.database1DataSet1.Employee);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.Employee' 資料表。您可以視需要進行移動或移除。

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bookIDTextBox_TextChanged(object sender, EventArgs e)
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (bookIDTextBox.Text != "" && titleTextBox.Text != "" && authorTextBox.Text != "" && publisherTextBox.Text != "" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                {
                    UpdateGrid("Insert into Employee values (\"" + bookIDTextBox.Text + "\",\"" + titleTextBox.Text + "\",\"" + authorTextBox.Text + "\",\"" + publisherTextBox.Text + "\",\"" + textBox1.Text + "\",\"" + textBox2.Text + "\"," + int.Parse(textBox3.Text) + "," + "\"" +textBox4.Text + "-" + textBox5.Text + "-" + textBox6.Text + "\"" + ");");
                    UpdateGrid("Select * from Employee");
                }
                else
                    MessageBox.Show("Please enter all of message");
            }
            catch (Exception E)
            {
                MessageBox.Show("Error enter! ");
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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
                UpdateGrid("Delete from Employee where StaffID = \"" + textBox7.Text + "\";");
                UpdateGrid("Select * from Employee");
            }
            catch (Exception E)
            {
                MessageBox.Show("Invalid value");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
