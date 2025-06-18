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
using Smile___Sunshine_Toy_Co__Ltd_CCMS;

namespace WindowsFormsApp1
{
    public partial class Logout : Form
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
        }

        public Logout()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            UpdateGrid("Delete from Data");
           LoginPages frm = new LoginPages();
            frm.ShowDialog();
            Close();
        }

        private void Logout_Load(object sender, EventArgs e)
        {

        }
    }
}
