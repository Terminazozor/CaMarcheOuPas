using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaMarcheOuPas
{
    public partial class MachineSettings : Form
    {
        public MachineSettings()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textNom.Text == "" || textIP.Text == "" || textIntervalle.Text == "")
            {
                MessageBox.Show("Un ou plusieur champ ne son pas remplis", "Erreur", MessageBoxButtons.OK);
            }
            else
            {
                Settings settings = new Settings();
                settings.SaveKeySettings("Machine/" + textNom.Text, textIP.Text + "/" + textIntervalle.Text);
                this.Close();
            }
        }
    }
}
