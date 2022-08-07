using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CaMarcheOuPas
{
    internal class Smtp : SmtpClient
    {
        public string mail { get; private set; }
        public string pwd { get; private set; }
        public Boolean SSL { get; private set; }
        public string host { get; private set; }
        public int port { get; private set; }
        public void WriteSttings(string mail,string pwd,Boolean SSL,string host,int port)
        {
            string[,] parameters = new string[5,2];
            this.mail = mail;
            parameters[0,0] = "mail";
            parameters[0,1] = mail;
            this.pwd = pwd;
            parameters[1,0] = "pwd";
            parameters[1,1] = pwd;
            this.SSL = SSL;
            parameters[2,0] = "SSL";
            parameters[2,1] = SSL.ToString();
            this.host = host;
            parameters[3,0] = "host";
            parameters[3,1] = host;
            this.port = port;
            parameters[4,0] = "port";
            parameters[4,1] = port.ToString();
            Settings settings = new Settings();
            settings.SaveSettings(parameters);
        }
        public void ReadSettings()
        {
            Settings settings = new Settings();
            if (settings.ReadOneSettings("mail") == null)
            {
                this.mail = "";
                this.pwd = "";
                this.SSL = false;
                this.host = "";
                this.port = 0;
            }
            else
            {
                this.mail = settings.ReadOneSettings("mail");
                this.pwd = settings.ReadOneSettings("pwd");
                if (settings.ReadOneSettings("SSL") == "True")
                {
                    this.SSL = true;
                }
                else
                {
                    this.SSL = false;
                }
                this.host = settings.ReadOneSettings("host");
                this.port = int.Parse(settings.ReadOneSettings("port"));
            }
        }
        public void NewMail(string Message, string Destinataire)
        {
            if (this.mail == null)
            {

            }
            else
            {
                MailMessage mailM = new MailMessage();
                mailM.From = new MailAddress(this.mail);
                mailM.To.Add(new MailAddress(Destinataire));
                mailM.Body = Message;
                mailM.Subject = "test";
                Send(mailM);
            }
        }
    }
}
