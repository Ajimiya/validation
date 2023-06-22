namespace Validation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            label4 = new Label();
            label5 = new Label();
            exit = new Button();
            logbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Javanese Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(345, 23);
            label1.Name = "label1";
            label1.Size = new Size(127, 47);
            label1.TabIndex = 0;
            label1.Text = "Login here";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(165, 103);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 1;
            label2.Text = "Username  : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(165, 164);
            label3.Name = "label3";
            label3.Size = new Size(117, 16);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(328, 103);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(299, 23);
            txtusername.TabIndex = 3;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(328, 157);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(299, 23);
            txtpassword.TabIndex = 4;
            //txtpassword.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(165, 215);
            label4.Name = "label4";
            label4.Size = new Size(122, 17);
            label4.TabIndex = 5;
            label4.Text = "Remember me ? ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(493, 214);
            label5.Name = "label5";
            label5.Size = new Size(134, 18);
            label5.TabIndex = 6;
            label5.Text = "Forgotpassword";
            // 
            // exit
            // 
            exit.BackColor = Color.FromArgb(128, 255, 255);
            exit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            exit.Location = new Point(165, 269);
            exit.Name = "exit";
            exit.Size = new Size(107, 42);
            exit.TabIndex = 7;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = false;
            // 
            // logbtn
            // 
            logbtn.BackColor = Color.FromArgb(128, 255, 255);
            logbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            logbtn.Location = new Point(520, 269);
            logbtn.Name = "logbtn";
            logbtn.Size = new Size(107, 42);
            logbtn.TabIndex = 8;
            logbtn.Text = "Login";
            logbtn.UseVisualStyleBackColor = false;
            logbtn.Click += logbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(769, 450);
            Controls.Add(logbtn);
            Controls.Add(exit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            /*Load += Form1_Load;*/
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Label label4;
        private Label label5;
        private Button exit;
        private Button logbtn;
    }
}