using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaMarcheOuPas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PingClass test = new PingClass("192.168.1.27");
            if (test.doPing())
            {
                Console.WriteLine("ca marche");
            }
            else
            {
                Console.WriteLine("ca ne marche pas ");
            }
            ShowMachine();
        }

        private void serveurSMTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingSMTP settingSMTP = new SettingSMTP();
            settingSMTP.Show();
        }

        private void parametreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingListForm settingListForm = new SettingListForm();
            settingListForm.Show();
        }
        private void ShowMachine()
        {
            int x = 35;
            int y = 35;
            var applicationSettings = ConfigurationManager.GetSection("appSettings") as NameValueCollection;
            foreach (var key in applicationSettings.AllKeys)
            {
                string machineVerif = key.Split('/')[0];
                if (machineVerif == "Machine")
                {
                    Label label = new Label();
                    label.Text=key.Split('/')[1];
                    label.Location = new Point(x, y);
                    label.Size = new Size(label.PreferredWidth, label.PreferredHeight);
                    label.Show();

                }
            }
        }
    }
}
