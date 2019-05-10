using System;

namespace asp_net_core_mailgun_httpclient.Services
{
    public class MailgunEmailSender : IEmailSender
    {
        private readonly MailConfigSection mailConfigSection;

        public MailgunEmailSender(MailConfigSection mailConfigSection)
        {
            this.mailConfigSection = mailConfigSection;
        }
        public void SendMail(string to, string subject, string body)
        {
        }
    }
}