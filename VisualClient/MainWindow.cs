using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseClient;

namespace VisualClient
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginSchemeBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loginContinueButton1.Enabled = true;
        }

        private void loginLoginButton1_Click(object sender, EventArgs e)
        {

            MySqlClient client = new MySqlClient(loginHostBox1.Text, loginUsernameBox1.Text, loginPasswordBox1.Text, "");
            if (!client.CheckConnection())
            {
                loginErrorBox1.Visible = true;
                loginErrorBox1.Text = String.Format("Login failed ErrorCode: {0}", client.LastError);
            }
            else
            {
                loginErrorBox1.Visible = true;
                loginErrorBox1.Text = "Login Successful";

                List<string> schemes = client.GetSchemes();

                foreach (string scheme in schemes)
                {
                    loginSchemeBox1.Items.Add(scheme);
                }
            }
        }

        private void loginContinueButton1_Click(object sender, EventArgs e)
        {
            loginPanel1.Visible = false;
        }
    }
}
