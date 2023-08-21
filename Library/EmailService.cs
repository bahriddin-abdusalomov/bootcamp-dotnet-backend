using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class EmailService
    {
        public List<EmailTemplate> Templates { get; set; }

        public List<MailMessage> Emails { get; set; }

        public EmailService() { 
            Templates = new List<EmailTemplate>();
            Emails = new List<MailMessage>();
        }

        public void SendEmail(string email)
        {
            string senderEmail = "sultonbek.rakhimov.recovery@gmail.com";
            string senderPassword = "szabguksrhwsbtie";

            // Recipient's email address
            string recipientEmail = email;

            // Create a new MailMessage object
            MailMessage mail = new MailMessage(senderEmail, recipientEmail);

            // Set the subject and body of the email
            mail.Subject = "Siz registratsiyadan o'tdingiz";
            mail.Body = "Tabriklaymiz!";

            // Create an SMTP client
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587); // Replace with your SMTP server address and port

            // Set the SMTP client credentials (username and password)
            smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);

            // Enable SSL encryption if required by your SMTP server
            smtpClient.EnableSsl = true;

            try
            {
                // Send the email
                smtpClient.Send(mail);
                Console.WriteLine("Email sent successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to send email: " + ex.Message);
            }
        }
    }
}
