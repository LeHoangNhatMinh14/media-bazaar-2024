using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Class
{
    public static class EmailService
    {
        public static void SendEmail(string password, string email)
        {
            {
                string senderemail = "MB.DGCGM02@outlook.com";
                string senderpassword = "MBpass02";
                string recipient = email;

                string subject = "MediaBazaar - Temporary password";
                string body = $"Your temporary password for the account is: {password}. \n" +
                    $"\n" +
                    $"Kind regards, \n" +
                    $"MediaBazaar \n" +
                    $"\n" +
                    $"Please be aware that this is email was sent automatically and no replies should be sent to this address!";

                MailMessage message = new MailMessage(senderemail, recipient, subject, body);

                SmtpClient client = new SmtpClient("smtp.office365.com", 587);
                client.EnableSsl = true;

                client.Credentials = new NetworkCredential(senderemail, senderpassword);

                client.Send(message);
            }

        }
    }
}
