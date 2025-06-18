using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smile___Sunshine_Toy_Co__Ltd_CCMS
{
    public partial class Report2 : Form
    {

        private DataTable dt = new DataTable();
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;"
                        + "Data Source=Database1.accdb";

        public Report2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        String sqlStr = "SELECT Produc_Name FROM Product";
        private void label4_Click(object sender, EventArgs e)
        {
            
        }


        string query = "SELECT Comment FROM Product ";
        String Comment;
        String Name;

        private void Report2_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter dataAdapter =
                        new OleDbDataAdapter(sqlStr, connStr);
            Comment = query.ToString();
            Name = sqlStr.ToString();
            label2.Text = Comment;
            label3.Text = sqlStr;


        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
