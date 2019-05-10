using System.Threading.Tasks;

namespace asp_net_core_mailgun_httpclient.Services
{
    public interface IEmailSender
    {
        Task SendMail(string to, string subject, string body);
    }
}