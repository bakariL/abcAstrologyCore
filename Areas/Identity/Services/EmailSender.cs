using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;



namespace ckl.Areas.Identity.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }

    public class EmailSender : IEmailSender
    {
        public IConfiguration _configuration { get; }
        private readonly ILogger _logger;

        public EmailSender(IConfiguration configuration, ILogger<EmailSender> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage )
        {
            SendMailMessage(email, subject, htmlMessage);
        }

        private void SendMailMessage(string sendTo, string subject, string body)
        {
            try
            {


               
          var message = new MimeMessage();
         message.From.Add(new MailboxAddress("Joey Tribbiani", "bakari.lewis1@outlook.com"));
         message.To.Add(new MailboxAddress("Mrs. Chanandler Bong", "bakarilewis@gmail.com"));
         message.Subject = "How you doin'?";

        // message.Body = new TextPart("plain")
        // {
        //     Text = @"Hey Chandler,I just wanted to let you know that Monica and I were going to go play some paintball, you in?-- Joey"
        // };

        using (var client = new SmtpClient())
        {
            client.Connect("smtp.sendgrid.net", 587);
            // Note: since we don't have an OAuth2 token, disable
            // the XOAUTH2 authentication mechanism.
            client.AuthenticationMechanisms.Remove("XOAUTH2");
             var bodyBuilder = new BodyBuilder ();
                    bodyBuilder.HtmlBody = "<b>This is some html text</b>";
                    bodyBuilder.TextBody = "This is some plain text";

                    message.Body = bodyBuilder.ToMessageBody ();

                    client.Send (message);

            // Note: only needed if the SMTP server requires authentication
            client.Authenticate("bakari.lewis1@outlook.com", "Ohio123!!");
            
            client.Send(message);
            client.Disconnect(true);
        }    
            //     var msg = new SendGridMessage();
            //     msg.SetFrom(new EmailAddress("bakari.lewis1@outlook.com", "SendGrid DX Team"));
            //     var recipients = new List<EmailAddress>
            //     {
            //         new EmailAddress("lewisbakari@yahoo.com", "Jeff Smith"),
            //         new EmailAddress("bakarilewis@gmail.com", "Anna Lidman")                };
            //     msg.AddTos(recipients);
            //     msg.SetSubject("Testing the SendGrid C# Library");
            //     msg.AddContent(MimeType.Text, "Hello World plain text!");
            //     msg.AddContent(MimeType.Html, "<p>Hello World!</p>");
            // var apiKey = "AstroABC";
            // var client = new SendGridClient(apiKey);

                // MailMessage htmlMessage;
                 //SmtpClient smtpClient;
                    

                // htmlMessage = new MailMessage(_configuration["EmailSender:FromAddress"], sendTo, subject, body);
                // htmlMessage.IsBodyHtml = true;
                // smtpClient = new SmtpClient(_configuration["EmailSender:SmtpServer"]);

                // if (string.IsNullOrEmpty(_configuration["EmailSender:Password"]))
                 //    smtpClient.UseDefaultCredentials = true;
               // else
                //     smtpClient.Credentials = new System.Net.NetworkCredential(_configuration["EmailSender:FromAddress"], _configuration["EmailSender:Password"]);

               //  if (Boolean.TryParse(_configuration["EmailSender:EnableSsl"], out bool enableSsl))
                 //    smtpClient.EnableSsl = enableSsl;


                // _logger.LogInformation($"Sent email in context of { subject } to: \"{ sendTo }\"");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed sending email in context of { subject } to: \"{ sendTo }\" Error: { ex.Message }");
            }
        }
    }
}
