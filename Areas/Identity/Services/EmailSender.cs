using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

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
                MailMessage htmlMessage;
                SmtpClient smtpClient;

                htmlMessage = new MailMessage(_configuration["EmailSender:FromAddress"], sendTo, subject, body);
                htmlMessage.IsBodyHtml = true;

                smtpClient = new SmtpClient(_configuration["EmailSender:SmtpServer"]);

                if (string.IsNullOrEmpty(_configuration["EmailSender:Password"]))
                    smtpClient.UseDefaultCredentials = true;
                else
                    smtpClient.Credentials = new System.Net.NetworkCredential(_configuration["EmailSender:FromAddress"], _configuration["EmailSender:Password"]);

                if (Boolean.TryParse(_configuration["EmailSender:EnableSsl"], out bool enableSsl))
                    smtpClient.EnableSsl = enableSsl;

                smtpClient.Send(htmlMessage);

                _logger.LogInformation($"Sent email in context of { subject } to: \"{ sendTo }\"");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed sending email in context of { subject } to: \"{ sendTo }\" Error: { ex.Message }");
            }
        }
    }
}
