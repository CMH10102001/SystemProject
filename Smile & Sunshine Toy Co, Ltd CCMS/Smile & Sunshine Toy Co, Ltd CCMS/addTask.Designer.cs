namespace Smile___Sunshine_Toy_Co__Ltd_CCMS
{
    partial class addTask
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
            System.Windows.Forms.Label lblPassword;
            System.Windows.Forms.Label lblName;
            System.Windows.Forms.Label lblJob;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label publisherLabel;
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bookIDTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            lblPassword = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            lblJob = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            publisherLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(33, 184);
            lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(32, 12);
            lblPassword.TabIndex = 133;
            lblPassword.Text = "Status";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(33, 42);
            lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(54, 12);
            lblName.TabIndex = 125;
            lblName.Text = "TaskName";
            lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblJob
            // 
            lblJob.AutoSize = true;
            lblJob.Location = new System.Drawing.Point(33, 77);
            lblJob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblJob.Name = "lblJob";
            lblJob.Size = new System.Drawing.Size(26, 12);
            lblJob.TabIndex = 127;
            lblJob.Text = "User";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(33, 114);
            authorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(45, 12);
            authorLabel.TabIndex = 129;
            authorLabel.Text = "DueDate";
            // 
            // publisherLabel
            // 
            publisherLabel.AutoSize = true;
            publisherLabel.Location = new System.Drawing.Point(33, 147);
            publisherLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new System.Drawing.Size(58, 12);
            publisherLabel.TabIndex = 131;
            publisherLabel.Text = "TaskOwner";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(193, 180);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 22);
            this.textBox2.TabIndex = 134;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bookIDTextBox
            // 
            this.bookIDTextBox.Location = new System.Drawing.Point(193, 39);
            this.bookIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.bookIDTextBox.Name = "bookIDTextBox";
            this.bookIDTextBox.Size = new System.Drawing.Size(148, 22);
            this.bookIDTextBox.TabIndex = 126;
            this.bookIDTextBox.TextChanged += new System.EventHandler(this.bookIDTextBox_TextChanged);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(193, 74);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(148, 22);
            this.titleTextBox.TabIndex = 128;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(193, 110);
            this.authorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(148, 22);
            this.authorTextBox.TabIndex = 130;
            this.authorTextBox.TextChanged += new System.EventHandler(this.authorTextBox_TextChanged);
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(193, 143);
            this.publisherTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(148, 22);
            this.publisherTextBox.TabIndex = 132;
            this.publisherTextBox.Text = "T";
            this.publisherTextBox.TextChanged += new System.EventHandler(this.publisherTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 26);
            this.button1.TabIndex = 135;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(lblPassword);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(lblName);
            this.Controls.Add(this.bookIDTextBox);
            this.Controls.Add(lblJob);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(authorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(publisherLabel);
            this.Controls.Add(this.publisherTextBox);
            this.Name = "addTask";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox bookIDTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.Button button1;
    }
}