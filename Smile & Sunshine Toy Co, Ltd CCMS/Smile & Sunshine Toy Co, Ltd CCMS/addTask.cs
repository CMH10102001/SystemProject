using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Smile___Sunshine_Toy_Co__Ltd_CCMS
{
    public partial class addTask : Form
    {

        private DataTable dt = new DataTable();
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
                        + "Data Source=Database1.accdb";

        public addTask()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        String TaskName;
        String User;
        String DueDate;
        String TaskOwner;
        String Status;

        private void bookIDTextBox_TextChanged(object sender, EventArgs e)
        {
            TaskName = bookIDTextBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TaskName) ||
                string.IsNullOrWhiteSpace(User) ||
                string.IsNullOrWhiteSpace(DueDate) ||
                string.IsNullOrWhiteSpace(Status))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }


            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Task (TaskName, User, DueDate, TaskOwner, Status) VALUES (?,?,?,?,?)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@TaskName", TaskName);
                        command.Parameters.AddWithValue("@Usere", User);
                        command.Parameters.AddWithValue("@DueDate", DueDate);
                        command.Parameters.AddWithValue("@Status", Status);

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

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            User = titleTextBox.Text;
        }

        private void authorTextBox_TextChanged(object sender, EventArgs e)
        {
            DueDate = authorTextBox.Text;
        }

        private void publisherTextBox_TextChanged(object sender, EventArgs e)
        {
            TaskOwner= publisherTextBox.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Status = textBox2.Text;
        }
    }
}
