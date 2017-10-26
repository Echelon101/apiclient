namespace VisualClient
{
    partial class LoginForm
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
            this.loginPortNumeric1 = new System.Windows.Forms.NumericUpDown();
            this.loginErrorBox1 = new System.Windows.Forms.TextBox();
            this.loginCheckBox1 = new System.Windows.Forms.CheckBox();
            this.loginPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPortNumeric1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // loginHostBox1
            // 
            this.loginHostBox1.Location = new System.Drawing.Point(31, 32);
            this.loginHostBox1.Margin = new System.Windows.Forms.Padding(4);
            this.loginHostBox1.Name = "loginHostBox1";
            this.loginHostBox1.Size = new System.Drawing.Size(132, 22);
            this.loginHostBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // loginUsernameBox1
            // 
            this.loginUsernameBox1.Location = new System.Drawing.Point(31, 81);
            this.loginUsernameBox1.Margin = new System.Windows.Forms.Padding(4);
            this.loginUsernameBox1.Name = "loginUsernameBox1";
            this.loginUsernameBox1.Size = new System.Drawing.Size(132, 22);
            this.loginUsernameBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // loginPasswordBox1
            // 
            this.loginPasswordBox1.Location = new System.Drawing.Point(31, 130);
            this.loginPasswordBox1.Margin = new System.Windows.Forms.Padding(4);
            this.loginPasswordBox1.Name = "loginPasswordBox1";
            this.loginPasswordBox1.Size = new System.Drawing.Size(132, 22);
            this.loginPasswordBox1.TabIndex = 5;
            this.loginPasswordBox1.UseSystemPasswordChar = true;
            // 
            // loginLoginButton1
            // 
            this.loginLoginButton1.Location = new System.Drawing.Point(31, 164);
            this.loginLoginButton1.Margin = new System.Windows.Forms.Padding(4);
            this.loginLoginButton1.Name = "loginLoginButton1";
            this.loginLoginButton1.Size = new System.Drawing.Size(100, 28);
            this.loginLoginButton1.TabIndex = 6;
            this.loginLoginButton1.Text = "Login";
            this.loginLoginButton1.UseVisualStyleBackColor = true;
            this.loginLoginButton1.Click += new System.EventHandler(this.loginLoginButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Schema";
            // 
            // loginSchemeBox1
            // 
            this.loginSchemeBox1.FormattingEnabled = true;
            this.loginSchemeBox1.Location = new System.Drawing.Point(31, 215);
            this.loginSchemeBox1.Margin = new System.Windows.Forms.Padding(4);
            this.loginSchemeBox1.Name = "loginSchemeBox1";
            this.loginSchemeBox1.Size = new System.Drawing.Size(160, 24);
            this.loginSchemeBox1.TabIndex = 8;
            this.loginSchemeBox1.SelectedIndexChanged += new System.EventHandler(this.loginSchemeBox1_SelectedIndexChanged);
            // 
            // loginContinueButton1
            // 
            this.loginContinueButton1.Enabled = false;
            this.loginContinueButton1.Location = new System.Drawing.Point(31, 250);
            this.loginContinueButton1.Margin = new System.Windows.Forms.Padding(4);
            this.loginContinueButton1.Name = "loginContinueButton1";
            this.loginContinueButton1.Size = new System.Drawing.Size(100, 28);
            this.loginContinueButton1.TabIndex = 9;
            this.loginContinueButton1.Text = "Continue";
            this.loginContinueButton1.UseVisualStyleBackColor = true;
            this.loginContinueButton1.Click += new System.EventHandler(this.loginContinueButton1_Click);
            // 
            // loginPanel1
            // 
            this.loginPanel1.Controls.Add(this.loginCheckBox1);
            this.loginPanel1.Controls.Add(this.loginPortNumeric1);
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
            this.loginPanel1.Location = new System.Drawing.Point(16, 15);
            this.loginPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.loginPanel1.Name = "loginPanel1";
            this.loginPanel1.Size = new System.Drawing.Size(347, 292);
            this.loginPanel1.TabIndex = 11;
            // 
            // loginPortNumeric1
            // 
            this.loginPortNumeric1.Location = new System.Drawing.Point(180, 31);
            this.loginPortNumeric1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.loginPortNumeric1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.loginPortNumeric1.Name = "loginPortNumeric1";
            this.loginPortNumeric1.Size = new System.Drawing.Size(120, 22);
            this.loginPortNumeric1.TabIndex = 12;
            this.loginPortNumeric1.Value = new decimal(new int[] {
            3306,
            0,
            0,
            0});
            // 
            // loginErrorBox1
            // 
            this.loginErrorBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginErrorBox1.Location = new System.Drawing.Point(230, 199);
            this.loginErrorBox1.Margin = new System.Windows.Forms.Padding(4);
            this.loginErrorBox1.Multiline = true;
            this.loginErrorBox1.Name = "loginErrorBox1";
            this.loginErrorBox1.ReadOnly = true;
            this.loginErrorBox1.Size = new System.Drawing.Size(101, 79);
            this.loginErrorBox1.TabIndex = 11;
            this.loginErrorBox1.Visible = false;
            // 
            // loginCheckBox1
            // 
            this.loginCheckBox1.AutoSize = true;
            this.loginCheckBox1.Checked = true;
            this.loginCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.loginCheckBox1.Location = new System.Drawing.Point(180, 81);
            this.loginCheckBox1.Name = "loginCheckBox1";
            this.loginCheckBox1.Size = new System.Drawing.Size(149, 21);
            this.loginCheckBox1.TabIndex = 13;
            this.loginCheckBox1.Text = "Verbindung Prüfen";
            this.loginCheckBox1.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.loginPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "MainWindow";
            this.loginPanel1.ResumeLayout(false);
            this.loginPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPortNumeric1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown loginPortNumeric1;
        private System.Windows.Forms.CheckBox loginCheckBox1;
    }
}