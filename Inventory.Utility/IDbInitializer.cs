using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Utility
{
   // public interface IWebHostEnvironment : Microsoft.Extensions.Hosting.IHostingEnvironment { }
    public interface IDbInitializer
    {
        Task CreateSuperAdmin();
        Task SendEmail(string fromEmail,string fromName, string subject,
            string message,string toEmail,string toName,
            string smtpUser,string smtpPassword,string smtpPort,
            string smtpHost, bool smtpSSL);
        Task<string> UploadFile(List<IFormFile> files, IHostingEnvironment env, string directory);
    }
}
