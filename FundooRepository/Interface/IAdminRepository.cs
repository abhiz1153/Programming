// --------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=IAdminRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------------------------------------
namespace FundooRepository.Interface
{
    using Common.Models.AdminModels;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    ///  Public interface for IAdminRepository 
    /// </summary>
    public interface IAdminRepository
    {
        /// <summary>
        /// Adds the admin.
        /// </summary>
        /// <param name="adminLogin">The admin login.</param>
        /// <returns></returns>
        Task AddAdmin(AdminLoginModel adminLogin);

        /// <summary>
        /// Admins the login.
        /// </summary>
        /// <param name="adminLogin">The admin login.</param>
        /// <returns></returns>
        Task<string> AdminLogin(AdminLoginModel adminLogin);

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        List<AdminModel> GetList();
    }
}
