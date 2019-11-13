// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace BussinessManager.Manager
{
    using BussinessManager.Interface;
    using Common.Models;
    using FundooRepository.Interface;
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// public class AccountManager
    /// </summary>
    /// <seealso cref="BussinessManager.Interface.IAccount" />
    public class AccountManager : IAccount
    {
        /// <summary>
        /// The account repository
        /// </summary>
        private readonly IAccountRepository accountRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountManager"/> class.
        /// </summary>
        public AccountManager() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountManager"/> class.
        /// </summary>
        /// <param name="accountRepository">The account repository.</param>
        public AccountManager(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        /// <summary>
        /// Registrations the asynchronous.
        /// </summary>
        /// <param name="userModels">The user models.</param>
        /// <returns>string</returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> RegistrationAsync(UserModel userModels)
        {
            try
            {
                await this.accountRepository.CreateAsync(userModels);
                return "USER ADDED SUCCESSFULLY";
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }          
        }

        /// <summary>
        /// Logins the asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns>string</returns>
        public async Task<UserModel> LoginAsync(LoginModel loginModel)
        {
            var result = await this.accountRepository.LoginAsync(loginModel);
            return result;

        }

        /// <summary>
        /// Facebooks the login asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns>string</returns>
        public async Task<UserModel> FacebookLoginAsync(LoginModel loginModel)
        {
            var result = await this.accountRepository.FacebookLoginAsync(loginModel);
            return result;

        }

        /// <summary>
        /// Googles the login asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns>string</returns>
        public async Task<UserModel> GoogleLoginAsync(LoginModel loginModel)
        {
            var result = await this.accountRepository.GoogleLoginAsync(loginModel);
            return result;

        }

        /// <summary>
        /// Resets the password asynchronous.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <returns>string</returns>
        public async Task<object> ResetPasswordAsync(ResetPasswordModel resetPasswordModel)
        {
            await this.accountRepository.ResetPasswordAsync(resetPasswordModel);
            return "PASSWORD CHANGED SUCCESSFULLY";
        }

        /// <summary>
        /// Forgets the password link asynchronous.
        /// </summary>
        /// <param name="forgetPasswordModel">The forget password model.</param>
        /// <returns>string</returns>
        public async Task<string> ForgetPasswordLinkAsync(ForgetPasswordModel forgetPasswordModel)
        {
            await this.accountRepository.ForgetPasswordLinkAsync(forgetPasswordModel);
            return "PASSWORD HAD SUCCESSFULLY SEND TO REGISTERED EMAIL ";
        }

        /// <summary>
        /// Logouts the asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns>result</returns>
        public string LogoutAsync(LoginModel loginModel)
        {
           var result =  this.accountRepository.Logout(loginModel);
            return result;
        }

        /// <summary>
        /// Uploads the images.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="profilePicture">The profile picture.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string UploadImages(string email, IFormFile profilePicture)
        {
            try
            {
               var result = this.accountRepository.UploadImages(email, profilePicture);
                return  result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Gets all user list asynchronous.
        /// </summary>
        /// <returns></returns>
        public List<UserModel> GetAllUserListAsync()
        {
            var list = new List<UserModel>();
            var result = this.accountRepository.GetUserList();
            if (result != null)
            {
                foreach (var item in result)
                {
                    list.Add(item);
                }
                return list;
            }
            else
            {
                return null;
            }
        }
    }
}
