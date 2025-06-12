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
    public partial class Employee1 : Form
    {

        private DataTable dt = new DataTable();
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;"
                        + "Data Source=Database1.accdb";
        public Employee1()
        {
            InitializeComponent();
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

        private void Employee1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'database1DataSet1.Department' 資料表。您可以視需要進行移動或移除。
            this.departmentTableAdapter.Fill(this.database1DataSet1.Department);
            // TODO: 這行程式碼會將資料載入 'database1DataSet1.Staff' 資料表。您可以視需要進行移動或移除。
            this.staffTableAdapter.Fill(this.database1DataSet1.Staff);
            dataGridView1.ReadOnly = true;
            if (lblText.Text == "1")
            {
                bt1.Visible = false;
            }
            UpdateGrid("Select * from Staff");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            Employee2 frm = new Employee2();
            frm.ShowDialog();
        }

        private void lblText_Click(object sender, EventArgs e)
        {

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
