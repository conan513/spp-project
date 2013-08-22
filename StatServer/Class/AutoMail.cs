using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace StatServer.Class
{
    class AutoMail
    {
        public void Send(string mail, string msg, string date)
        {
            try
            {
                MailMessage m = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                m.From = new MailAddress("spp.automail@gmail.com");
                m.To.Add(mail);

                m.Subject = "SPP Bugreport Automail - " + date;
                m.Body = msg + Environment.NewLine + Environment.NewLine + "Thank you for using the SPP report system, your report is being processed." + Environment.NewLine + Environment.NewLine +
                                        "This is in an automated message - do not reply to the sender.";
                //m.Body = "This is in an automated message - do not reply to the sender.";

                //System.Net.Mail.Attachment attachment;
                //attachment = new System.Net.Mail.Attachment("your attachment file");
                //mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("spp.automail@gmail.com", "sppautomail");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(m);
            }
            catch
            {
            }
        }
    }
}
