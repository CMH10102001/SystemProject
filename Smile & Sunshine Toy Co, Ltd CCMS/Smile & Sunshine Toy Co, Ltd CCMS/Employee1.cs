﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smile___Sunshine_Toy_Co__Ltd_CCMS
{
    public partial class Employee1 : Form
    {
        public Employee1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Product1 frm = new Product1();
            frm.ShowDialog();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Companies frm = new Companies();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
