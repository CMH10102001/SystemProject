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
    public partial class LoginPages : Form
    {
        public bool Login = false;

        private DataTable dt1 = new DataTable();
        private DataTable dt2 = new DataTable();
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Database1.accdb";
        private void UpdateGrid(string sqlStr)
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
            dt1.Clear();
            dataAdapter.Fill(dt1);
            dataAdapter.Dispose();
        }
        public LoginPages()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sqlStr = "";
            Login = false;

            if (txtUsername.Text.Length == 0 ||
            txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Missing username or password. "
                            + "Please try again.");
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                try
                {
                    DataTable dt = new DataTable();
                    sqlStr = "SELECT Password FROM Staff WHERE Staff_Id = '" + txtUsername.Text + "'";
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
                    dataAdapter.Fill(dt);
                    dataAdapter.Dispose();
                    if (dt.Rows.Count > 0 && txtPassword.Text.Equals(dt.Rows[0]["Password"].ToString()))
                        Login = true;

                    if (Login)
                    {
                        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;";
                        string query = "SELECT Department_Id FROM Staff WHERE Staff_Id = @StaffId";
                        string departmentId = "";

                        using (OleDbConnection connection = new OleDbConnection(connectionString))
                        {
                            OleDbCommand command = new OleDbCommand(query, connection);
                            command.Parameters.AddWithValue("@StaffId", txtUsername.Text);
                            connection.Open();

                            object result = command.ExecuteScalar();
                            if (result != null)
                            {
                                departmentId = result.ToString();
                            }
                            else
                            {
                                departmentId = "Not Found";
                            }
                        }
                        UpdateGrid("Insert into Data values (\"" + txtUsername.Text + "\",\"" + departmentId + "\",\"" + txtPassword.Text + "\")");
                        Home frm = new Home();
                        frm.ShowDialog();
                        Close();

                    }
                    else
                    {
                        MessageBox.Show("Incorrect user name or password. " + "Please try again.");
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nSQL: " + sqlStr);
                }
            }
        }

        private void LoginPages_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'database1DataSet1.Data' 資料表。您可以視需要進行移動或移除。
            this.dataTableAdapter.Fill(this.database1DataSet1.Data);

        }

        private void password_Click(object sender, EventArgs e)
        {

        }
    }
}
