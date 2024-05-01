using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Core.Services.Email
{
    public class EmailSender : IEmailSender
    {

        private readonly IConfiguration _config;

        public EmailSender(IConfiguration config)
        {
            _config = config;

        }
        public async Task SendEmailAsync(string fromAddress, string toAddress, string subject, string message)
        {
            var mailMessage = new MailMessage(fromAddress, toAddress, subject, message);

            using (var client = new SmtpClient(_config["SMTPDEV:Host"], int.Parse(_config["SMTPDEV:Port"]))
            {
                Credentials = new NetworkCredential(_config["SMTPDEV:Username"], _config["SMTPDEV:Password"])
            })
            {
                await client.SendMailAsync(mailMessage);
            }
        }
    }
}
