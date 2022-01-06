using mysql.Application.Models.Mail;
using System.Threading.Tasks;

namespace mysql.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
