using Microsoft.Extensions.Configuration;
using MimeKit;
using MailKit.Net.Smtp;
using System;
using System.Threading.Tasks;
using MailKit.Security;

namespace Turbo.az.Extensions
{
    // Removed the EmailSender namespace to avoid conflict
    public interface IEmailService
    {
        Task SendEmailAsync(string to, string subject, string message);
    }

    public class EmailSender : IEmailService
    {
        public readonly IConfiguration _configuration;

        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string to, string subject, string message)
        {
            try
            {
                var emailSettings = _configuration.GetSection("EmailSettings");

                var mimeMessage = new MimeMessage();
                mimeMessage.From.Add(new MailboxAddress(emailSettings["FromName"], emailSettings["FromEmail"]));
                mimeMessage.To.Add(MailboxAddress.Parse(to));
                mimeMessage.Subject = subject;
                mimeMessage.Body = new TextPart("plain") { Text = message };

                using var client = new SmtpClient();
                await client.ConnectAsync(emailSettings["SmtpServer"], int.Parse(emailSettings["SmtpPort"]), SecureSocketOptions.SslOnConnect);
                await client.AuthenticateAsync(emailSettings["SmtpUsername"], emailSettings["SmtpPassword"]);
                await client.SendAsync(mimeMessage);
                await client.DisconnectAsync(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
                throw;
            }
        }
    }

}
