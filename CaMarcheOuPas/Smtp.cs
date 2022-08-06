using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CaMarcheOuPas
{
    internal class Smtp : SmtpClient
    {
        Smtp()
        {
            UseDefaultCredentials = true;
        }
        public void ReadSettings()
        {

        }
    }
}
