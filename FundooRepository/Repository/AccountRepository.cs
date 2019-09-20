// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FundooRepository.Repository
{
    using Common.Models;
    using FundooRepository.DBContext;
    using FundooRepository.Interface;
    using Microsoft.AspNetCore.Identity;
    using System.Threading.Tasks;
    using System.Linq;
    using Microsoft.IdentityModel.Tokens;
    using System.Security.Claims;
    using System;
    using System.IdentityModel.Tokens.Jwt;
    using System.Net.Mail;
    using Microsoft.Extensions.Caching.Distributed;

    /// <summary>
    /// Public Class for AccountRepository
    /// </summary>
    public class AccountRepository : IAccountRepository
    {
        /// <summary>
        /// private User Context
        /// </summary>
        private readonly UserContext userContext;

        private readonly IDistributedCache distributedCache;
        
        public AccountRepository(UserContext userContext , IDistributedCache distributedCache)
        {
            this.userContext = userContext;
            this.distributedCache = distributedCache;
        }
       /// <summary>
       /// public Task CreateAsync
       /// </summary>
       /// <param name="userModels"></param>
       /// <returns></returns>
        public Task CreateAsync(UserModel userModels)
        {
            
            UserModel userModel = new UserModel()

            {
                FirstName = userModels.FirstName,
                LastName = userModels.LastName,
                Email = userModels.Email,
                City = userModels.City,
                Password = userModels.Password
            };
            userContext.Register.Add(userModel);
            return Task.Run(() => userContext.SaveChanges());
        }
        /// <summary>
        /// public async Task LoginAsync
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public async Task<string> LoginAsync(LoginModel loginModel)
        {
            var result = await this.FindByEmailAsync(loginModel.Email);
            if (result != null)
            {
                bool user = userContext.Register.Any(p => p.Password == loginModel.Password && p.Email == loginModel.Email);
                if (user)
                {
                    try
                    {
                        Guid guid = Guid.NewGuid();
                        string token = Convert.ToString(guid);
                        var cachekey = loginModel.Email;
                        this.distributedCache.GetString(cachekey);
                        this.distributedCache.SetString(cachekey, token);
                        return cachekey + " Token Number = " + token;
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                }
            }
            return "INVALID USER";

        }
         /// <summary>
        /// public Task<IdentityUser> for FindByEmailAsync
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public Task<IdentityUser> FindByEmailAsync(string email)
        {
            UserModel user = userContext.Register.Where(r => r.Email == email).SingleOrDefault();
            IdentityUser identityUser = new IdentityUser()
            {
                Email = user.Email
            };
            return Task.Run(() => identityUser);
        }
        /// <summary>
        /// public async Task<object> ResetPasswordAsync
        /// </summary>
        /// <param name="resetPasswordModel"></param>
        /// <returns></returns>
        public async Task<object> ResetPasswordAsync(ResetPasswordModel resetPasswordModel)
        {
            var userEmail = await this.FindByEmailAsync(resetPasswordModel.Email);
            if (userEmail != null)
            {
                var result = this.GeneratePasswordReset(resetPasswordModel);
                return "success";
            }
            return "email is not matched";
        }
        /// <summary>
        ///   public Task GeneratePasswordReset
        /// </summary>
        /// <param name="resetPasswordModel"></param>
        /// <returns></returns>
        public Task GeneratePasswordReset(ResetPasswordModel resetPasswordModel)
        {
            var result = userContext.Register.Where(p => p.Email == resetPasswordModel.Email).SingleOrDefault();
            result.Password = resetPasswordModel.Password;
            userContext.Update(result);
            return Task.Run(() => userContext.SaveChanges());

        }
        /// <summary>
        ///  public async Task ForgetPasswordLinkAsync
        /// </summary>
        /// <param name="forgetPasswordModel"></param>
        /// <returns></returns>
        public async Task ForgetPasswordLinkAsync(ForgetPasswordModel forgetPasswordModel)
        {
            await this.FindByEmailAsync(forgetPasswordModel.Email);
            
            var fromAddress = new MailAddress("abhiz1153@gmail.com");            
            var fromPassword = "Abhi98shek@";
            var toAddress = new MailAddress(forgetPasswordModel.Email);
            string subject = "Reset Password";
            string body = "To reset your password click link :-  https://localhost:5001/api/resetpassword";
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })

                smtp.Send(message);            
        }
    }
}