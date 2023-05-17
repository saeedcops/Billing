using Inventory.Models;
using Inventory.Repository;
using Inventory.Utility.HelperClass;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;

namespace Inventory.Utility
{
    public class DbInitializer : IDbInitializer
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private SuperAdmin _superAdmin;
        private ApplicationDbContext _dbContext;
        private IRoleInventory _roleInventory;

        public DbInitializer(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IOptions<SuperAdmin> superAdmin, ApplicationDbContext dbContext, IRoleInventory roleInventory)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _superAdmin = superAdmin.Value;
            _dbContext = dbContext;
            _roleInventory = roleInventory;
        }

        public async Task CreateSuperAdmin()
        {
            AppUser appUser = new AppUser();
            appUser.Email = _superAdmin.Email;
            appUser.UserName = _superAdmin.Email;
            appUser.EmailConfirmed = true;
            var response = await _userManager.CreateAsync(appUser, _superAdmin.Password);

            if(response.Succeeded)
            {
                UserProfile userProfile = new UserProfile();
                userProfile.FirstName = "Admin";
                userProfile.LastName = "Admin";
                userProfile.Email = appUser.Email;
                userProfile.AppUserId = appUser.Id;
                await _dbContext.UserProfiles.AddAsync(userProfile);
                await _dbContext.SaveChangesAsync();
                await _roleInventory.AddRoleAsync(appUser.Id);

            }
        }

        public async Task SendEmail(string fromEmail, string fromName, string subject, string message, string toEmail, string toName, string smtpUser, string smtpPassword, string smtpPort, string smtpHost, bool smtpSSL)
        {
            var body = message;
            var messageRequest = new MailMessage();
            messageRequest.To.Add( new MailAddress(toEmail,toName));
            messageRequest.From = new MailAddress(fromEmail,fromName);
            messageRequest.Subject = subject;
            messageRequest.Body = body;
            messageRequest.IsBodyHtml = true;
            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = smtpUser,
                    Password = smtpPassword,
                };

                smtp.Credentials = credential;
                smtp.Host = smtpHost;
                smtp.Port =Convert.ToInt32( smtpPort);
                smtp.EnableSsl = smtpSSL;
               await smtp.SendMailAsync(messageRequest);
            }
        }

        public async Task<string> UploadFile(List<IFormFile> files, IHostingEnvironment env, string directory)
        {
            var response = string.Empty;
            var fileExtention = string.Empty;
            var filePath = string.Empty;
            var fileName = string.Empty;
            var upload = Path.Combine(env.WebRootPath, directory);

            foreach (var file in files)
            {
                if(file.Length > 0)
                {
                    fileExtention = Path.GetExtension(file.FileName);
                    fileName = Guid.NewGuid().ToString()+fileExtention;
                    filePath = Path.Combine(upload, fileName);

                    using (var ms = new FileStream(filePath,FileMode.Create))
                    {
                        await file.CopyToAsync(ms);
                    }

                    response = fileName;
                }
                
            }
            return response;
        }
    }
}
