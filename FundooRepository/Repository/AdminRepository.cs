using Common.Models.AdminModels;
using FundooRepository.DBContext;
using FundooRepository.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly IConfiguration configuration;
        private readonly UserContext userContext;

        public AdminRepository(IConfiguration configuration, UserContext userContext)
        {
            this.configuration = configuration;
            this.userContext = userContext;
        }
        public Task AddAdmin(AdminLoginModel adminLogin)
        {
            AdminLoginModel admin = new AdminLoginModel()
            {
                Email = adminLogin.Email,
                FirstName = adminLogin.FirstName,
                LastName = adminLogin.LastName,
                Password = adminLogin.Password
            };
            userContext.AdminLogin.Add(admin);
            return Task.Run(() => userContext.SaveChanges());
        }
        public async Task<string> AdminLogin(AdminLoginModel adminLogin)
        {
            var result = await this.FindByEmailAsync(adminLogin.Email);
            if (result != null)
            {
                bool admin = userContext.AdminLogin.Any(a => a.Email == adminLogin.Email && a.Password == adminLogin.Password);
                if (admin)
                {
                    try
                    {
                        return "LOGIN SUCCESSFUL";
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                }
            }
            return "INVALID ADMIN DETAILS";
        }
        public Task<IdentityUser> FindByEmailAsync(string email)
        {
            AdminLoginModel admin = userContext.AdminLogin.Where(a => a.Email == email).Single();
            IdentityUser identityUser = new IdentityUser()
            {
                Email = admin.Email
            };
            return Task.Run(() => identityUser);
        }
        public List<AdminModel> GetList()
        {
            return this.userContext.Admin.ToList<AdminModel>();

        }
    }
}