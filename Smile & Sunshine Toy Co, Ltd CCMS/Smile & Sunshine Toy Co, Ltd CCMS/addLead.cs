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
using System.Windows.Forms.DataVisualization.Charting;

namespace Smile___Sunshine_Toy_Co__Ltd_CCMS
{
    public partial class addLead : Form
    {

        String FullName;
        String Title;
        String Company;
        String PhoneNumber;
        String Email;
        String LeadStatus;
        String LeadOwner;

        private DataTable dt = new DataTable();
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
                        + "Data Source=Database1.accdb";
        public addLead()
        {
            InitializeComponent();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Email = textBox2.Text;
        }
        private void bookIDTextBox_TextChanged(object sender, EventArgs e)
        {
            FullName = bookIDTextBox.Text;
        }

        private void lblJob_Click(object sender, EventArgs e)
        {

        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            Title = titleTextBox.Text;
        }

        private void authorLabel_Click(object sender, EventArgs e)
        {

        }

        private void authorTextBox_TextChanged(object sender, EventArgs e)
        {
            Company = authorTextBox.Text;
        }

        private void publisherLabel_Click(object sender, EventArgs e)
        {

        }

        private void publisherTextBox_TextChanged(object sender, EventArgs e)
        {
            PhoneNumber = publisherTextBox.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LeadOwner = textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            LeadOwner = textBox3.Text;
        }

        private void button_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(FullName) ||
                string.IsNullOrWhiteSpace(Email) ||
                string.IsNullOrWhiteSpace(LeadStatus) ||
                string.IsNullOrWhiteSpace(LeadOwner))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"INSERT INTO Staff 
                            (FullName, Title, Company, PhoneNumber, mail, LeadStatus, LeadOwner) 
                            VALUES (?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@FullName", FullName);
                        command.Parameters.AddWithValue("@Title", Title);
                        command.Parameters.AddWithValue("@Company", Company);
                        command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        command.Parameters.AddWithValue("@mail", Email);
                        command.Parameters.AddWithValue("@LeadStatus", LeadStatus);
                        command.Parameters.AddWithValue("@LeadOwner", LeadOwner);

                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} row(s) inserted.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void addLead_Load(object sender, EventArgs e)
        {

        }
    }
}
