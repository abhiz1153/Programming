// ---------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=IAccount.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// ---------------------------------------------------------------------------------------------------------------------------------------------------------
namespace BussinessManager.Interface
{
    using Common.Models;
    using Microsoft.AspNetCore.Http;
    using System.Collections.Generic;
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
        Task<string> RegistrationAsync(UserModel userModels);

        /// <summary>
        /// Logins the asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        Task<UserModel> LoginAsync(LoginModel loginModel);

        /// <summary>
        /// Resets the password asynchronous.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        Task<object> ResetPasswordAsync(ResetPasswordModel resetPasswordModel);

        /// <summary>
        /// Forgets the password link asynchronous.
        /// </summary>
        /// <param name="forgetPasswordModel">The forget password model.</param>
        Task<string> ForgetPasswordLinkAsync(ForgetPasswordModel forgetPasswordModel);

        /// <summary>
        /// Facebooks the login asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        Task<UserModel> FacebookLoginAsync(LoginModel loginModel);

        /// <summary>
        /// Googles the login asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        string LogoutAsync(LoginModel loginModel);

        /// <summary>
        /// Uploads the images.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="profilePicture">The profile picture.</param>
        string UploadImages(string email, IFormFile profilePicture);

        /// <summary>
        /// Gets all user list asynchronous.
        /// </summary>
        List<UserModel> GetAllUserListAsync();

        /// <summary>
        /// Googles the login asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        Task<UserModel> GoogleLoginAsync(LoginModel loginModel);
    }
}
