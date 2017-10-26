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
using System.Net;

namespace VisualClient
{
    public partial class LoginForm : Form
    {
        private MySqlClient client;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginSchemeBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loginContinueButton1.Enabled = true;
        }

        private void loginLoginButton1_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (loginCheckBox1.Checked) {
                try
                {
                    System.Net.NetworkInformation.Ping pingSender = new System.Net.NetworkInformation.Ping();
                    System.Net.NetworkInformation.PingReply pingReply = pingSender.Send(loginHostBox1.Text);

                    if (pingReply == null || pingReply.Status != System.Net.NetworkInformation.IPStatus.Success || error)
                    {
                        error = true;
                        if (pingReply != null)
                        {
                            MessageBox.Show(pingReply.Status.ToString(), "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Ping Failed", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                } catch (Exception ex)
                {
                    error = true;
                    MessageBox.Show(ex.InnerException.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!error)
            {
                this.client = new MySqlClient(loginHostBox1.Text, loginPortNumeric1.Value, loginUsernameBox1.Text, loginPasswordBox1.Text, "");
                if (!client.CheckMySqlConnection())
                {
                    switch (int.Parse(client.LastError[0]))
                    {
                        case 0:
                            MessageBox.Show(client.LastError[1], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 1045:
                            MessageBox.Show(client.LastError[1], "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 1042:
                            break;
                        default:
                            MessageBox.Show(client.LastError[0] + " " + client.LastError[1], "MySql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                {
                    List<string> schemes = client.GetSchemes();

                    foreach (string scheme in schemes)
                    {
                        loginSchemeBox1.Items.Add(scheme);
                    }
                }
            }
            /*System.Net.NetworkInformation.PingReply pingReply = client.CheckHostConnection(loginHostBox1.Text);
            if (pingReply != null && pingReply.Status == System.Net.NetworkInformation.IPStatus.Success)
            {
                if (!client.CheckMySqlConnection())
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
            else
            {
                loginErrorBox1.Visible = true;
                if (pingReply != null)
                {
                    loginErrorBox1.Text = pingReply.Status.ToString();
                }
            }*/
        }

        private void loginContinueButton1_Click(object sender, EventArgs e)
        {
            loginPanel1.Visible = false;
        }
    }
}
