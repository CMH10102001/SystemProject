﻿using System;
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
    public partial class Companies2 : Form
    {

        private void UpdateGrid(string sqlStr)
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
            dt.Clear();
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();
            dataGridView1.DataSource = dt;
        }

        private void UpdateGrid1(string sqlStr)
        {
            OleDbDataAdapter dataAdapter1 = new OleDbDataAdapter(sqlStr, connStr);
            dt.Clear();
            dataAdapter1.Fill(dt);
            dataAdapter1.Dispose();
            dataGridView2.DataSource = dt;
        }

        private DataTable dt = new DataTable();
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;"
                        + "Data Source=Database1.accdb";

        public Companies2()
        {
            InitializeComponent();
        }

        private void Companies2_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'database1DataSet1.Supplier' 資料表。您可以視需要進行移動或移除。
            this.supplierTableAdapter.Fill(this.database1DataSet1.Supplier);
            // TODO: 這行程式碼會將資料載入 'database1DataSet1.Material_Requirement_Form' 資料表。您可以視需要進行移動或移除。
            this.material_Requirement_FormTableAdapter.Fill(this.database1DataSet1.Material_Requirement_Form);

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

            string connectionString1 = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;";
            string query1 = "SELECT Department FROM Data";

            using (OleDbConnection connection1 = new OleDbConnection(connectionString1))
            {
                connection1.Open();
                OleDbCommand command = new OleDbCommand(query1, connection1);
                object result = command.ExecuteScalar();
                string a = result != null ? result.ToString() : string.Empty;
                if (a == "D001" && a != "D002" && a != "D003" && a != "D004" && a != "D006")
                {
                    MessageBox.Show("Not Access");
                    Close();
                }
            }


        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox11.Text != "" && textBox10.Text != "")
                {
                    UpdateGrid1("Insert into Supplier values (\"" + textBox10.Text + "\",\"" + textBox11.Text + "\");");
                    UpdateGrid1("Select * from Supplier");
                }
                else
                    MessageBox.Show("Please enter all of message");
            }
            catch (Exception E)
            {
                MessageBox.Show("Error enter! ");
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox12.Text == "")
                {
                    MessageBox.Show("Cannot be empty! ");
                }
                else
                {
                    UpdateGrid1("Delete from Supplier where Supplier_Id = \"" + textBox12.Text + "\";");
                    UpdateGrid1("Select * from Supplier");
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Invalid value !");
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox9.Text == "")
                {
                    MessageBox.Show("Cannot be empty! ");
                }
                else
                {
                    UpdateGrid("Delete from Material_Requirement_Form where Form_Number = \"" + textBox9.Text + "\";");
                    UpdateGrid("Select * from  Material_Requirement_Form");
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Invalid value !");
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void authorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void publisherTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (bookIDTextBox.Text != "" && titleTextBox.Text != "" && authorTextBox.Text != "" && publisherTextBox.Text != "" && textBox2.Text != "" && textBox4.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox3.Text != "" && textBox8.Text != "" && textBox5.Text != "")
                {
                    UpdateGrid("Insert into Material_Requirement_Form values (\"" + bookIDTextBox.Text + "\",\"" + titleTextBox.Text + "\",\"" + authorTextBox.Text + "\",\"" + publisherTextBox.Text + "\"," + int.Parse(textBox2.Text) + "," + int.Parse(textBox4.Text) + ",\"" + textBox5.Text + "\"," + int.Parse(textBox6.Text) + ",\"" + textBox7.Text + "\",\"" + textBox3.Text + "\",\"" + textBox8.Text + "\");");
                    UpdateGrid("Select * from  Material_Requirement_Form");
                }
                else
                    MessageBox.Show("Please enter all of message");
            }
            catch (Exception E)
            {
                MessageBox.Show("Error enter! ");
            }
        }

        private void authorLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
            Employee1 frm = new Employee1();
            frm.ShowDialog();
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
