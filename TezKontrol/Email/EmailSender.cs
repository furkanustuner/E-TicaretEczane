using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using SendGrid.Helpers.Mail.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TezKontrol.Email
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SendGridClient(Options.SendGridKey);
            var mesaj = new SendGridMessage()
            {
                From = new EmailAddress("cemalfurkanustuner@gmail.com", "Altun"),
                Subject = subject,
                PlainTextContent=htmlMessage,
                HtmlContent=htmlMessage

            };
            mesaj.AddTo(new EmailAddress(email));
            try
            {
                return client.SendEmailAsync(mesaj);
            }
            catch (Exception)
            {

                throw;
            }
            return null;
        }
        public EmailOptions Options { get; set; }
        public EmailSender(IOptions<EmailOptions> emailOptions)
        {
            Options = emailOptions.Value;
        }






    }

    internal class SendGridGridMessage
    {
       

        public EmailAddress From { get; set; }
        public string Subject { get; set; }
        public string PlainTextContent { get; set; }
        public string HtmlContent { get; set; }

        internal void AddTo(EmailAddress emailAddress)
        {
            throw new NotImplementedException();
        }
    }
}
