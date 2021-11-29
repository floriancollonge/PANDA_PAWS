using System;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace paws.communication
{
    public class MailCommunicationHelper : CommunicationHelper
    {
        private static readonly string SENDGRID_API_KEY = "SENDGRID_API_KEY";

        public void Send(CommunicationRequest request)
        {
            string apiKey = Environment.GetEnvironmentVariable(SENDGRID_API_KEY);
            SendGridClient client = new SendGridClient(apiKey);
            EmailAddress from = new EmailAddress(request.FromAddress, request.FromName);
            string subject = request.Subject;
            EmailAddress to = new EmailAddress(request.TargetAddress, request.TargetName);
            string plainTextContent = request.Content;
            string htmlContent = request.HtmlContent;
            SendGridMessage msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            client.SendEmailAsync(msg);
        }
    }
}