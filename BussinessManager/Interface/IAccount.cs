// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IAccount.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace BussinessManager.Interface
{
    using Common.Models;
    using System.Threading.Tasks;
    /// <summary>
    /// Public Interface for IAccount
    /// </summary>
    public interface IAccount
    {
        /// <summary>
        /// Registrations the asynchronous.
        /// </summary>
        /// <param name="userModels">The user models.</param>
        /// <returns></returns>
        Task<string> RegistrationAsync(UserModel userModels);
        /// <summary>
        /// Logins the asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        Task<string> LoginAsync(LoginModel loginModel);
        /// <summary>
        /// Resets the password asynchronous.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <returns></returns>
        Task<object> ResetPasswordAsync(ResetPasswordModel resetPasswordModel);
        /// <summary>
        /// Forgets the password link asynchronous.
        /// </summary>
        /// <param name="forgetPasswordModel">The forget password model.</param>
        /// <returns></returns>
        Task<string> ForgetPasswordLinkAsync(ForgetPasswordModel forgetPasswordModel);
    }
}
