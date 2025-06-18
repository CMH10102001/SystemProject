namespace WindowsFormsApp1
{
    partial class Logout
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnYes = new System.Windows.Forms.Button();
            this.BtnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logout the system?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnYes
            // 
            this.BtnYes.BackColor = System.Drawing.Color.Lime;
            this.BtnYes.Location = new System.Drawing.Point(115, 99);
            this.BtnYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(50, 37);
            this.BtnYes.TabIndex = 1;
            this.BtnYes.Text = "Yes";
            this.BtnYes.UseVisualStyleBackColor = false;
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // BtnNo
            // 
            this.BtnNo.BackColor = System.Drawing.Color.Red;
            this.BtnNo.Location = new System.Drawing.Point(194, 99);
            this.BtnNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(58, 37);
            this.BtnNo.TabIndex = 2;
            this.BtnNo.Text = "No";
            this.BtnNo.UseVisualStyleBackColor = false;
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // Logout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 291);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.BtnYes);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Logout";
            this.Text = "Logout";
            this.Load += new System.EventHandler(this.Logout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnYes;
        private System.Windows.Forms.Button BtnNo;
    }
}