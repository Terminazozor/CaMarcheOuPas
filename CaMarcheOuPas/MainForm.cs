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
            Smtp test = new Smtp();
            //test.WriteSttings("mail","pwd", true, "host", 15654);
            //Console.WriteLine(test.Host);
            var applicationSettings = ConfigurationManager.GetSection("appSettings") as NameValueCollection;
            foreach (var key in applicationSettings.AllKeys)
            {
                Console.WriteLine(key + " = " + applicationSettings[key]);
            }
        }
    }
}
