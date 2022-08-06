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
        public string mail;
        public string pwd;
        public Boolean SSL;
        public string host;
        public int port;
        public void WriteSttings(string mail,string pwd,Boolean SSL,string host,int port)
        {
            Console.WriteLine("ca rentre");
            Console.WriteLine(mail);
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
            SaveSettings(parameters);
            Console.WriteLine("je sors");
        }
        public void ReadSettings()
        {

        }
        public string ReadOneSettings(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? null;
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
                return null;
            }
        }
        public void SaveSettings(string[,] parameters)
        {
            Console.WriteLine("ca rentre saveSet");
            for(int i = 0; i < parameters.GetLength(0); i++)
            {
                Console.WriteLine(i.ToString());
                SaveKeySettings(parameters[i, 0], parameters[i,1]);
            }
        }
        public void SaveKeySettings(string key, string value)
        {
            Console.WriteLine("Ca rentre saveKey");
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                    Console.WriteLine(key);
                }
                else
                {
                    settings[key].Value = value;
                    Console.WriteLine(key);
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
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
