namespace Smile___Sunshine_Toy_Co__Ltd_CCMS
{
    partial class Product2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label lblPassword;
            System.Windows.Forms.Label lblEmail;
            System.Windows.Forms.Label lblName;
            System.Windows.Forms.Label lblJob;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label publisherLabel;
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new Smile___Sunshine_Toy_Co__Ltd_CCMS.Database1DataSet1();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.productTableAdapter = new Smile___Sunshine_Toy_Co__Ltd_CCMS.Database1DataSet1TableAdapters.ProductTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bookIDTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            lblJob = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            publisherLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(1050, 900);
            label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(83, 18);
            label14.TabIndex = 112;
            label14.Text = "Product ID";
            label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(333, 346);
            lblPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(99, 18);
            lblPassword.TabIndex = 121;
            lblPassword.Text = "Product_Cost";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(333, 400);
            lblEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(153, 18);
            lblEmail.TabIndex = 123;
            lblEmail.Text = "Product_Descripttion";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(333, 134);
            lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(82, 18);
            lblName.TabIndex = 113;
            lblName.Text = "Product_Id";
            // 
            // lblJob
            // 
            lblJob.AutoSize = true;
            lblJob.Location = new System.Drawing.Point(333, 186);
            lblJob.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblJob.Name = "lblJob";
            lblJob.Size = new System.Drawing.Size(109, 18);
            lblJob.TabIndex = 115;
            lblJob.Text = "Product_Name";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(333, 242);
            authorLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(66, 18);
            authorLabel.TabIndex = 117;
            authorLabel.Text = "Column:";
            // 
            // publisherLabel
            // 
            publisherLabel.AutoSize = true;
            publisherLabel.Location = new System.Drawing.Point(333, 291);
            publisherLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new System.Drawing.Size(111, 18);
            publisherLabel.TabIndex = 119;
            publisherLabel.Text = "Depertment_Id";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1518, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 18);
            this.label12.TabIndex = 31;
            this.label12.Text = "Admin";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(316, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 29);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "Search here";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 900);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 18);
            this.label11.TabIndex = 65;
            this.label11.Text = "Settings";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 831);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 18);
            this.label10.TabIndex = 64;
            this.label10.Text = "Activities";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 762);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 18);
            this.label9.TabIndex = 63;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 694);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 62;
            this.label8.Text = "Invoices";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 630);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 61;
            this.label7.Text = "Reports";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 558);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 60;
            this.label6.Text = "Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 59;
            this.label5.Text = "Deals";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 58;
            this.label4.Text = "Companies";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 57;
            this.label3.Text = "Leads";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 56;
            this.label2.Text = "Tasks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 55;
            this.label1.Text = "Leads Dashboard";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.columnDataGridViewTextBoxColumn,
            this.productCostDataGridViewTextBoxColumn,
            this.productDescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(316, 448);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1404, 300);
            this.dataGridView1.TabIndex = 77;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "Product_Id";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "Product_Id";
            this.productIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // columnDataGridViewTextBoxColumn
            // 
            this.columnDataGridViewTextBoxColumn.DataPropertyName = "Column";
            this.columnDataGridViewTextBoxColumn.HeaderText = "Column";
            this.columnDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.columnDataGridViewTextBoxColumn.Name = "columnDataGridViewTextBoxColumn";
            this.columnDataGridViewTextBoxColumn.Width = 150;
            // 
            // productCostDataGridViewTextBoxColumn
            // 
            this.productCostDataGridViewTextBoxColumn.DataPropertyName = "Product_Cost";
            this.productCostDataGridViewTextBoxColumn.HeaderText = "Product_Cost";
            this.productCostDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productCostDataGridViewTextBoxColumn.Name = "productCostDataGridViewTextBoxColumn";
            this.productCostDataGridViewTextBoxColumn.Width = 150;
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            this.productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Product_Description";
            this.productDescriptionDataGridViewTextBoxColumn.HeaderText = "Product_Description";
            this.productDescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            this.productDescriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1146, 886);
            this.textBox7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(220, 29);
            this.textBox7.TabIndex = 111;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1378, 873);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 56);
            this.btnDelete.TabIndex = 110;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(1558, 873);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(162, 56);
            this.btnadd.TabIndex = 109;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(573, 340);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 29);
            this.textBox2.TabIndex = 122;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(573, 394);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(220, 29);
            this.textBox3.TabIndex = 124;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // bookIDTextBox
            // 
            this.bookIDTextBox.Location = new System.Drawing.Point(573, 129);
            this.bookIDTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bookIDTextBox.Name = "bookIDTextBox";
            this.bookIDTextBox.Size = new System.Drawing.Size(220, 29);
            this.bookIDTextBox.TabIndex = 114;
            this.bookIDTextBox.TextChanged += new System.EventHandler(this.bookIDTextBox_TextChanged);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(573, 182);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(220, 29);
            this.titleTextBox.TabIndex = 116;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(573, 236);
            this.authorTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(220, 29);
            this.authorTextBox.TabIndex = 118;
            this.authorTextBox.TextChanged += new System.EventHandler(this.authorTextBox_TextChanged);
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(573, 285);
            this.publisherTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(220, 29);
            this.publisherTextBox.TabIndex = 120;
            this.publisherTextBox.TextChanged += new System.EventHandler(this.publisherTextBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Smile___Sunshine_Toy_Co__Ltd_CCMS.Properties.Resources.png1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 198);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label18.Location = new System.Drawing.Point(28, 448);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 18);
            this.label18.TabIndex = 125;
            this.label18.Text = "Employee";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // Product2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1768, 938);
            this.Controls.Add(this.label18);
            this.Controls.Add(lblPassword);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(lblEmail);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(lblName);
            this.Controls.Add(this.bookIDTextBox);
            this.Controls.Add(lblJob);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(authorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(publisherLabel);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(label14);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Name = "Product2";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnadd;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Database1DataSet1TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmnetIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox bookIDTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.Label label18;
    }
}