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
            IPAddress host;
            Utilities utilities = new Utilities();
            if (loginIpRadio1.Checked)
            {
                if(loginHostBox1.Text.ToLower() == "localhost")
                {
                    IPAddress.TryParse(loginHostBox1.Text, out host);
                }
            }
            else if (loginIpRadio2.Checked)
            {
                if(!IPAddress.TryParse(loginHostBox1.Text, out IPAddress ip))
                {
                    host = utilities.FqdnToIpv6(loginHostBox1.Text);
                }
                else
                {
                    int state;
                    string[] content = utilities.Ipv4ToIpv6(loginHostBox1.Text);
                    switch (ip.AddressFamily)
                    {
                        case System.Net.Sockets.AddressFamily.InterNetwork:
                            if (int.TryParse(content[1], out state))
                            {
                                switch (state)
                                {
                                    case 1:
                                        IPAddress.TryParse(content[0], out host);
                                        break;
                                    case -1:
                                        loginErrorBox1.Visible = true;
                                        loginErrorBox1.Text = content[3];
                                        break;
                                    case -2:
                                        loginErrorBox1.Visible = true;
                                        loginErrorBox1.Text = content[3];
                                        loginErrorBox1.ForeColor = Color.Red;
                                        break;
                                    default:
                                        break;
                                }
                            }
                            break;
                        case System.Net.Sockets.AddressFamily.InterNetworkV6:
                            host = ip;
                            break;
                    }
                }
            }
            else if (loginIpRadio3.Checked)
            {

            } 
            MySqlClient client = new MySqlClient(host, loginPortNumeric1.Value, loginUsernameBox1.Text, loginPasswordBox1.Text, "");
            System.Net.NetworkInformation.PingReply pingReply = client.CheckHostConnection(loginHostBox1.Text);
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
            }
        }

        private void loginContinueButton1_Click(object sender, EventArgs e)
        {
            loginPanel1.Visible = false;
        }
    }
}
