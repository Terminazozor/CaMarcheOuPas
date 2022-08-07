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
    }
}
