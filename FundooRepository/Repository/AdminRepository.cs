// --------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=AdminRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------------------------------------
namespace FundooRepository.Repository
{
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

    /// <summary>
    ///  Public Class for AdminRepository
    /// </summary>
    /// <seealso cref="FundooRepository.Interface.IAdminRepository" />
    public class AdminRepository : IAdminRepository
    {
        /// <summary>
        /// The configuration
        /// </summary>
        private readonly IConfiguration configuration;

        /// <summary>
        /// The user context
        /// </summary>
        private readonly UserContext userContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminRepository"/> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        /// <param name="userContext">The user context.</param>
        public AdminRepository(IConfiguration configuration, UserContext userContext)
        {
            this.configuration = configuration;
            this.userContext = userContext;
        }

        /// <summary>
        /// Adds the admin.
        /// </summary>
        /// <param name="adminLogin">The admin login.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Admins the login.
        /// </summary>
        /// <param name="adminLogin">The admin login.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Finds the by email asynchronous.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
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