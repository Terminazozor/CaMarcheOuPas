using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;

namespace CaMarcheOuPas
{
    internal class Settings
    {
        public void SaveSmtpParameter()
        {

        }
        public void readConfig()
        {
            string test;
            test = ConfigurationManager.AppSettings.Get("test");
            Console.WriteLine("The value of test is " + test);
        }
    }
}
