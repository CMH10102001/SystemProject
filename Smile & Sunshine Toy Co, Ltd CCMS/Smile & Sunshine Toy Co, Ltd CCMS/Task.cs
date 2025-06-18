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
    public partial class Task : Form
    {

        private DataTable dt = new DataTable();
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;"
                        + "Data Source=Database1.accdb";
        private object database1DataSet1;   

        public Task()
        {
            InitializeComponent();
        }

        private void UpdateGrid(string sqlStr)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, conn))
                    {
                        dt.Clear();
                        dataAdapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            addTask newForm = new addTask();
            newForm.Show();
        }

        private void Task_Load(object sender, EventArgs e)
        {
            UpdateGrid("Select TaskName, User, DueDate, TaskOwner, Status from Task ");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
