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
    public partial class SettingListForm : Form
    {
        public SettingListForm()
        {
            InitializeComponent();
            ShowMachine();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MachineSettings machineSettings = new MachineSettings();
            machineSettings.Show();
        }
        private void ShowMachine()
        {
            var applicationSettings = ConfigurationManager.GetSection("appSettings") as NameValueCollection;
            foreach (var key in applicationSettings.AllKeys)
            {
                string machineVerif = key.Split('/')[0];
                if (machineVerif == "Machine")
                {
                    listMachine.Items.Add(key.Split('/')[1] +"-IP:"+ applicationSettings[key].Split('/')[0] + "-Intervalle:" + applicationSettings[key].Split('/')[1]);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listMachine.SelectedItems.Count>0)
            {
                string toDelete = listMachine.SelectedItems[0].ToString();
                Settings settings = new Settings();
                settings.DeleteSettingsKey("Machine/" + toDelete.Split('-')[0]);
                Console.WriteLine("Machine/" + toDelete.Split('-')[0]);
                listMachine.Items.Clear();
                ShowMachine();
            }
        }
    }
}
