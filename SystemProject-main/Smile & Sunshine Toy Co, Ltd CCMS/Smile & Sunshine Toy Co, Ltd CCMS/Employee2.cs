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
    public partial class Employee2 : Form
    {

        private DataTable dt = new DataTable();
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;"
                        + "Data Source=Database1.accdb";


        private void UpdateGrid(string sqlStr)
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
            dt.Clear();
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();
            dataGridView1.DataSource = dt;
        }

        private void UpdateGrid1(string sqlStr)
        {
            OleDbDataAdapter dataAdapter1 = new OleDbDataAdapter(sqlStr, connStr);
            dt.Clear();
            dataAdapter1.Fill(dt);
            dataAdapter1.Dispose();
            dataGridView2.DataSource = dt;
        }

        public Employee2()
        {
            InitializeComponent();
        }

        private void Employee2_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'database1DataSet1.Department' 資料表。您可以視需要進行移動或移除。
            this.departmentTableAdapter.Fill(this.database1DataSet1.Department);
            // TODO: 這行程式碼會將資料載入 'database1DataSet1.Staff' 資料表。您可以視需要進行移動或移除。
            this.staffTableAdapter.Fill(this.database1DataSet1.Staff);

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

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (bookIDTextBox.Text != "" && titleTextBox.Text != "" && authorTextBox.Text != "" && publisherTextBox.Text != "" && textBox1.Text != "" && textBox2.Text != "")
                {
                    UpdateGrid("Insert into Staff values (\"" + bookIDTextBox.Text + "\",\"" + titleTextBox.Text + "\",\"" + authorTextBox.Text + "\",\"" + publisherTextBox.Text + "\",\"" + textBox2.Text + "\");");
                    UpdateGrid("Select * from Staff");
                }
                else
                    MessageBox.Show("Please enter all of message");
            }
            catch (Exception E)
            {
                MessageBox.Show("Error enter! ");
            }
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
                    UpdateGrid1("Delete from Staff where Staff_Id = \"" + textBox7.Text + "\";");
                    UpdateGrid1("Select * from Staff");
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if  (textBox4.Text != "" && textBox3.Text != "")
                {
                    UpdateGrid1("Insert into Department values (\"" + textBox4.Text + "\",\"" + textBox3.Text + "\");");
                    UpdateGrid1("Select * from Department");
                }
                else
                    MessageBox.Show("Please enter all of message");
            }
            catch (Exception E)
            {
                MessageBox.Show("Error enter! ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox5.Text == "")
                {
                    MessageBox.Show("Cannot be empty! ");
                }
                else
                {
                    UpdateGrid1("Delete from Department where Department_Id = \"" + textBox5.Text + "\";");
                    UpdateGrid1("Select * from Department");
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Invalid value !");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
            Employee1 frm = new Employee1();
            frm.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Companies1 frm = new Companies1();
            frm.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
           Product1 frm = new Product1();
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home frm = new Home();
            frm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Task frm = new Task();
            frm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Leads frm = new Leads();
            frm.ShowDialog();
        }
    }
}
