using OA1.Domain.Settings;
using System.Threading.Tasks;

namespace OA1.Service.Contract
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
