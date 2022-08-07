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
            ReadConfig readConfig = new ReadConfig();
            readConfig.SaveSettings(parameters);
        }
        public void ReadSettings()
        {
            ReadConfig readConfig = new ReadConfig();
            this.mail = readConfig.ReadOneSettings("mail");
            this.pwd = readConfig.ReadOneSettings("pwd");
            if (readConfig.ReadOneSettings("SSL") == "True")
            {
                this.SSL = true;
            }
            else
            {
                this.SSL = false;
            }
            this.host = readConfig.ReadOneSettings("host");
            this.port = int.Parse(readConfig.ReadOneSettings("port"));
        }
        public void NewMail(string Message, string Destinataire)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("csharpvalentintest@hotmail.com");
            mail.To.Add(new MailAddress(Destinataire));
            mail.Body = Message;
            mail.Subject = "test";
            Send(mail);
        }
    }
}
