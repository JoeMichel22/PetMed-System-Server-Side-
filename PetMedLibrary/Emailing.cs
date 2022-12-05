using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace PetMedLibrary
{
    public class Emailing
    {
        private MailMessage mailOBJ = new MailMessage();
        private MailAddress emailTo;
        private MailAddress emailFrom= new MailAddress("tun69277@temple.edu");
        private string emailSubject = "Password Recovery";
        private string emailBody;
        private string emailHost = "smtp.temple.edu";
        private MailPriority emailPriority = MailPriority.Normal;

        public Emailing()
        {

        }
        public string Sender
        {
            get { return emailFrom.ToString(); }
            set { emailFrom = new MailAddress(value); }
        }
        public string Reciever
        {
            get { return emailTo.ToString(); }
            set { emailTo = new MailAddress(value); }
        }
        public string Subject
        {
            get { return emailSubject; }
            set { emailSubject = value; }
        }
        public string Message
        {
            get { return emailBody; }
            set { emailBody = value; }
        }
        public string MailHost
        {
            get { return emailHost; }
            set { emailHost = value; }
        }
        public MailPriority Priority
        {
            get { return emailPriority; }
            set { emailPriority = value; }
        }

        public string RecoverPassword()
        {
            try
            {
                mailOBJ.To.Add(emailTo);
                mailOBJ.From = emailFrom;
                mailOBJ.Subject = emailSubject;
                mailOBJ.Body = emailBody;
                mailOBJ.Priority = emailPriority;

                SmtpClient smtpServer = new SmtpClient(emailHost);
                smtpServer.Send(mailOBJ);

                return "Password recovery email sent succefully";
            }
            catch(Exception ex)
            {
                return "The password recovery email was not sent because " + ex.ToString();
            }
            
        }
    }
}
