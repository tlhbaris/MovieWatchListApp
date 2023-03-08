using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.Business.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(string toEmail, string subject, string content);

    }

    public class SendGridMailAsync : IMailService
    {
        public Task SendEmailAsync(string toEmail, string subject, string content)
        {
            throw new NotImplementedException();
        }
    }




}
