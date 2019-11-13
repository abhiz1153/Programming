// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AdminManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
using BussinessManager.Interface;
using Common.Models.AdminModels;
using FundooRepository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManager.Manager
{
    /// <summary>
    /// public class AdminManager
    /// </summary>
    /// <seealso cref="BussinessManager.Interface.IAdmin" />
    public class AdminManager : IAdmin
    {
        /// <summary>
        /// The admin repository
        /// </summary>
        private readonly IAdminRepository adminRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminManager"/> class.
        /// </summary>
        /// <param name="adminRepository">The admin repository.</param>
        public AdminManager(IAdminRepository adminRepository)
        {
            this.adminRepository = adminRepository;
        }

        /// <summary>
        /// Adds the admin asynchronous.
        /// </summary>
        /// <param name="adminLogin">The admin login.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Task AddAdminAsync(AdminLoginModel adminLogin)
        {
            try
            {
                var result = this.adminRepository.AddAdmin(adminLogin);
                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Admins the login asynchronous.
        /// </summary>
        /// <param name="adminLogin">The admin login.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> AdminLoginAsync(AdminLoginModel adminLogin)
        {
            try
            {
                var result = await this.adminRepository.AdminLogin(adminLogin);
                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Gets all list asynchronous.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<AdminModel> GetAllListAsync()
        {
            try
            {
                var list = new List<AdminModel>();
                var result = this.adminRepository.GetList();
                foreach (var item in result)
                {
                    list.Add(item);
                }
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
