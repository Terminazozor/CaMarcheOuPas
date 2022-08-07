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
    public partial class SettingSMTP : Form
    {
        public SettingSMTP()
        {
            InitializeComponent();
            Smtp smtp = new Smtp();
            smtp.ReadSettings();
            textMail.Text = smtp.mail;
            textPwd.Text = smtp.pwd;
            checkSSL.Checked = smtp.SSL;
            textHost.Text = smtp.host;
            textPort.Text = smtp.port.ToString();
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Smtp smtp = new Smtp();
            if(textMail.Text=="" || textPwd.Text=="" || textHost.Text=="" || textPort.Text == "")
            {
                MessageBox.Show("Un ou plusieur champ ne son pas remplis", "Erreur", MessageBoxButtons.OK);
            }
            else
            {
                smtp.WriteSttings(textMail.Text, textPwd.Text, checkSSL.Checked, textHost.Text, int.Parse(textPort.Text));
                smtp.ReadSettings();
                textMail.Text = smtp.mail;
                textPwd.Text = smtp.pwd;
                checkSSL.Checked = smtp.SSL;
                textHost.Text = smtp.host;
                textPort.Text = smtp.port.ToString();
            }
        }
    }
}
