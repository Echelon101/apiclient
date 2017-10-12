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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client client = new Client(textBox1.Text, textBox2.Text, textBox3.Text, "");
            if (!client.CheckConnection())
            {
                label5.Visible = true;
                label5.Text = "Login Failed";
            }else if (client.CheckConnection())
            {
                label5.Visible = true;
                label5.Text = "Login Successful";

                List<string> schemes = client.GetSchemes();

                foreach (string scheme in schemes)
                {
                    comboBox1.Items.Add(new ListViewItem(scheme));
                }
            }
            
        }
    }
}
