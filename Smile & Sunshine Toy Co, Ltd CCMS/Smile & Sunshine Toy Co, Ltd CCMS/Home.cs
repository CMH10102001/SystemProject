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
using WindowsFormsApp1;

namespace Smile___Sunshine_Toy_Co__Ltd_CCMS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;";
            string query = @"SELECT Staff.StaffName FROM Data INNER JOIN Staff ON CStr(Data.Staff_Id) = CStr(Staff.Staff_Id)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    OleDbCommand command = new OleDbCommand(query, connection);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    label12.Text = (result) != null ? result.ToString() : "404Error";
                }
                catch (Exception ex)
                {
                    label12.Text = $"錯誤：{ex.Message}";
                }
            }
        }
        private void label18_Click(object sender, EventArgs e)
        {
            Employee1 frm = new Employee1();
            frm.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Logout frm = new Logout();
            frm.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Report1 frm = new Report1();
            frm.ShowDialog();
        }
    }
}
