namespace VisualClient
{
    partial class MainWindow
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
            this.loginHostBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginUsernameBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginPasswordBox1 = new System.Windows.Forms.TextBox();
            this.loginLoginButton1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.loginSchemeBox1 = new System.Windows.Forms.ComboBox();
            this.loginContinueButton1 = new System.Windows.Forms.Button();
            this.loginPanel1 = new System.Windows.Forms.Panel();
            this.loginErrorBox1 = new System.Windows.Forms.TextBox();
            this.loginPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // loginHostBox1
            // 
            this.loginHostBox1.Location = new System.Drawing.Point(3, 17);
            this.loginHostBox1.Name = "loginHostBox1";
            this.loginHostBox1.Size = new System.Drawing.Size(100, 20);
            this.loginHostBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // loginUsernameBox1
            // 
            this.loginUsernameBox1.Location = new System.Drawing.Point(3, 57);
            this.loginUsernameBox1.Name = "loginUsernameBox1";
            this.loginUsernameBox1.Size = new System.Drawing.Size(100, 20);
            this.loginUsernameBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // loginPasswordBox1
            // 
            this.loginPasswordBox1.Location = new System.Drawing.Point(3, 97);
            this.loginPasswordBox1.Name = "loginPasswordBox1";
            this.loginPasswordBox1.Size = new System.Drawing.Size(100, 20);
            this.loginPasswordBox1.TabIndex = 5;
            this.loginPasswordBox1.UseSystemPasswordChar = true;
            // 
            // loginLoginButton1
            // 
            this.loginLoginButton1.Location = new System.Drawing.Point(3, 124);
            this.loginLoginButton1.Name = "loginLoginButton1";
            this.loginLoginButton1.Size = new System.Drawing.Size(75, 23);
            this.loginLoginButton1.TabIndex = 6;
            this.loginLoginButton1.Text = "Login";
            this.loginLoginButton1.UseVisualStyleBackColor = true;
            this.loginLoginButton1.Click += new System.EventHandler(this.loginLoginButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Schema";
            // 
            // loginSchemeBox1
            // 
            this.loginSchemeBox1.FormattingEnabled = true;
            this.loginSchemeBox1.Location = new System.Drawing.Point(3, 166);
            this.loginSchemeBox1.Name = "loginSchemeBox1";
            this.loginSchemeBox1.Size = new System.Drawing.Size(121, 21);
            this.loginSchemeBox1.TabIndex = 8;
            this.loginSchemeBox1.SelectedIndexChanged += new System.EventHandler(this.loginSchemeBox1_SelectedIndexChanged);
            // 
            // loginContinueButton1
            // 
            this.loginContinueButton1.Enabled = false;
            this.loginContinueButton1.Location = new System.Drawing.Point(3, 194);
            this.loginContinueButton1.Name = "loginContinueButton1";
            this.loginContinueButton1.Size = new System.Drawing.Size(75, 23);
            this.loginContinueButton1.TabIndex = 9;
            this.loginContinueButton1.Text = "Continue";
            this.loginContinueButton1.UseVisualStyleBackColor = true;
            this.loginContinueButton1.Click += new System.EventHandler(this.loginContinueButton1_Click);
            // 
            // loginPanel1
            // 
            this.loginPanel1.Controls.Add(this.loginErrorBox1);
            this.loginPanel1.Controls.Add(this.loginContinueButton1);
            this.loginPanel1.Controls.Add(this.loginSchemeBox1);
            this.loginPanel1.Controls.Add(this.label4);
            this.loginPanel1.Controls.Add(this.loginLoginButton1);
            this.loginPanel1.Controls.Add(this.loginPasswordBox1);
            this.loginPanel1.Controls.Add(this.label3);
            this.loginPanel1.Controls.Add(this.loginUsernameBox1);
            this.loginPanel1.Controls.Add(this.label2);
            this.loginPanel1.Controls.Add(this.loginHostBox1);
            this.loginPanel1.Controls.Add(this.label1);
            this.loginPanel1.Location = new System.Drawing.Point(12, 12);
            this.loginPanel1.Name = "loginPanel1";
            this.loginPanel1.Size = new System.Drawing.Size(235, 240);
            this.loginPanel1.TabIndex = 11;
            // 
            // loginErrorBox1
            // 
            this.loginErrorBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginErrorBox1.Location = new System.Drawing.Point(141, 17);
            this.loginErrorBox1.Multiline = true;
            this.loginErrorBox1.Name = "loginErrorBox1";
            this.loginErrorBox1.ReadOnly = true;
            this.loginErrorBox1.Size = new System.Drawing.Size(76, 64);
            this.loginErrorBox1.TabIndex = 11;
            this.loginErrorBox1.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.loginPanel1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.loginPanel1.ResumeLayout(false);
            this.loginPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginHostBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginUsernameBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginPasswordBox1;
        private System.Windows.Forms.Button loginLoginButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox loginSchemeBox1;
        private System.Windows.Forms.Button loginContinueButton1;
        private System.Windows.Forms.Panel loginPanel1;
        private System.Windows.Forms.TextBox loginErrorBox1;
    }
}