// ---------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=IAdmin.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// ---------------------------------------------------------------------------------------------------------------------------------------------------------
namespace BussinessManager.Interface
{
    using Common.Models.AdminModels;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    ///  public interface for Admin
    /// </summary>
    public interface IAdmin
    {
        /// <summary>
        /// Adds the admin asynchronous.
        /// </summary>
        /// <param name="adminLogin">The admin login.</param>
        Task AddAdminAsync(AdminLoginModel adminLogin);

        /// <summary>
        /// Admins the login asynchronous.
        /// </summary>
        /// <param name="adminLogin">The admin login.</param>
        Task<string> AdminLoginAsync(AdminLoginModel adminLogin);

        /// <summary>
        /// Gets all list asynchronous.
        /// </summary>
        List<AdminModel> GetAllListAsync();
    }
}
