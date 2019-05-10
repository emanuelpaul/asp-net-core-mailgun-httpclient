namespace asp_net_core_mailgun_httpclient.Services
{
    public interface IEmailSender
    {
        void SendMail(string to, string subject, string body);
    }
}