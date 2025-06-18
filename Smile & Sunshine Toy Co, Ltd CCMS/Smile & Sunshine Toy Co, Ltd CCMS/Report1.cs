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
    public partial class Report1 : Form
    {

        private DataTable dt = new DataTable();
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Database1.accdb";

        private object database1DataSet11;
        private object ProductTableAdapter;

        public Report1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dgv = sender as DataGridView;
                string columnName = dgv.Columns[e.ColumnIndex].Name;

                if (columnName == "Details")
                {
                    DataGridViewRow row = dgv.Rows[e.RowIndex];
                    Report2 newForm = new Report2();
                    newForm.Show();
                }
            }
        }

        private void Report1_Load(object sender, EventArgs e)
        {
            UpdateGrid("SELECT Product_Name, FinishDate, RespondedStaff, StaffJobTitle FROM Product");
        }


        private void UpdateGrid(string sqlStr)
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
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

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
