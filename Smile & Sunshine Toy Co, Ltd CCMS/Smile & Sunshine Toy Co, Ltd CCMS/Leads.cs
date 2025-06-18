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
    public partial class Leads : Form
    {
        public Leads()
        {
            InitializeComponent();
        }



        String FullName;
        String Titler;
        String Company;
        String PhoneNumber;
        String Email;
        String LeadStatus;
        String LeadOwner;



        private DataTable dt = new DataTable();
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;"
                        + "Data Source=Database1.accdb";


        private object database1DataSet1;

        public object LeaddataAdapter { get; private set; }

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


        private void Leads_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'database1DataSet11.Staff' 資料表。您可以視需要進行移動或移除。
            this.staffTableAdapter.Fill(this.database1DataSet11.Staff);
            UpdateGrid("Select StaffName, JobTitle, Company, PhoneNo, Email, LeaderStatus, LeadOwner from Staff");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Companies1 frm = new Companies1();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addLead newForm = new addLead();
            newForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
