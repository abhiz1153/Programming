// ----------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=IAccountRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// ----------------------------------------------------------------------------------------------------------------------------------------------------------

namespace FundooRepository.Interface
{
    using Common.Models;
    using Microsoft.AspNetCore.Identity;
    using System.Threading.Tasks;
    /// <summary>
    /// Public interface for IAccountRepository 
    /// </summary>
    public interface IAccountRepository
    {
        /// <summary>
        /// Creates the asynchronous.
        /// </summary>
        /// <param name="usedrModel">The usedr model.</param>
        /// <returns></returns>
        Task CreateAsync(UserModel usedrModel);
        /// <summary>
        /// Logins the asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        Task<string> LoginAsync(LoginModel loginModel);
        /// <summary>
        /// Finds the by email asynchronous.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        Task<IdentityUser> FindByEmailAsync(string email);
        /// <summary>
        /// Resets the password asynchronous.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <returns></returns>
        Task<object> ResetPasswordAsync(ResetPasswordModel resetPasswordModel);
        /// <summary>
        /// Generates the password reset.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <returns></returns>
        Task GeneratePasswordReset(ResetPasswordModel resetPasswordModel);
        /// <summary>
        /// Forgets the password link asynchronous.
        /// </summary>
        /// <param name="forgetPasswordModel">The forget password model.</param>
        /// <returns></returns>
        Task ForgetPasswordLinkAsync(ForgetPasswordModel forgetPasswordModel);
    }
}
