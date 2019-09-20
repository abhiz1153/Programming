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
        /// <returns></returns>
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
        /// <returns></returns>
        public async Task<string> LoginAsync(LoginModel loginModel)
        {
          var result=  await this.accountRepository.LoginAsync(loginModel);
            return ("USER SUCCESSFULLY LOGIN. Catchkey = " + result);
               
        }
        /// <summary>
        /// Resets the password asynchronous.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <returns></returns>
        public async Task<object> ResetPasswordAsync(ResetPasswordModel resetPasswordModel)
        {
            await this.accountRepository.ResetPasswordAsync(resetPasswordModel);
            return "PASSWORD CHANGED SUCCESSFULLY";
        }
        /// <summary>
        /// Forgets the password link asynchronous.
        /// </summary>
        /// <param name="forgetPasswordModel">The forget password model.</param>
        /// <returns></returns>
        public async Task<string> ForgetPasswordLinkAsync(ForgetPasswordModel forgetPasswordModel)
        {
            await this.accountRepository.ForgetPasswordLinkAsync(forgetPasswordModel);
            return "PASSWORD HAD SUCCESSFULLY SEND TO REGISTER EMAIL ";
        }
    }

}
