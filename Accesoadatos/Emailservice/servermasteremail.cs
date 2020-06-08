using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Accesoadatos.Emailservice
{
    public abstract class servermasteremail
    {
        private SmtpClient SmtpClient;
        protected string senderMail {get; set; }
        protected string Password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }


        protected void inicializarsmtpcliente()
        {
            SmtpClient = new SmtpClient();
            SmtpClient.Credentials = new NetworkCredential(senderMail,Password);
            SmtpClient.Host = host;
            SmtpClient.Port = port;
            SmtpClient.EnableSsl = ssl;
        }

        public void sendMail(string subject, string body, List<string> recipienteMail )
        {
            var mailmessage = new MailMessage();

            try
            {
                mailmessage.From = new MailAddress(senderMail);
                foreach (string mail in recipienteMail)
                {
                    mailmessage.To.Add(mail);
                }

                mailmessage.Subject = subject;
                mailmessage.Body = body;
                mailmessage.Priority = MailPriority.Normal;
                SmtpClient.Send(mailmessage);
            }

             


            catch (Exception)
            {

            }
            finally {
                mailmessage.Dispose();
                SmtpClient.Dispose();

            }
        }

    }
}
