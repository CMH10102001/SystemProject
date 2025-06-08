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
using System.Xml;

namespace Smile___Sunshine_Toy_Co__Ltd_CCMS
{
    public partial class Employee1 : Form
    {

        private DataTable dt = new DataTable();
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;"
                        + "Data Source=Database1.accdb";
        private void Employee1_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            if (lblText.Text == "1")
            {
                bt1.Visible = false;
            }
            UpdateGrid("Select * from Employee");
        }

        public Employee1()
        {
            InitializeComponent();
            {

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Product1 frm = new Product1();
            frm.ShowDialog();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Companies frm = new Companies();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lblText.Text!= "1")
            {
                int a = int.Parse(lblText.Text);
                a--;
                lblText.Text = a.ToString();
                lbl1.Text = "Showing the staff of " + lblText.Text;
            }
            if (lblText.Text == "1")
            {
                bt1.Visible=false;
            }
        }
        private void UpdateGrid(string sqlStr)
        {
            OleDbDataAdapter dataAdapter =
                        new OleDbDataAdapter(sqlStr, connStr);
            dt.Clear();
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();
            dataGridView1.DataSource = dt;
        }



        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeeTableAdapter2.Fill(this.database1DataSet1.Employee);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void bookIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
        }

        private void btnLast_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee2 frm = new Employee2();
            frm.ShowDialog();
        }
    }
}
