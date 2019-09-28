﻿// --------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------------------------------------
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
    using Microsoft.Extensions.Configuration;
    using System.Text;
    using StackExchange.Redis;

    /// <summary>
    /// Public Class for AccountRepository
    /// </summary>
    public class AccountRepository : IAccountRepository
    {
        /// <summary>
        /// The iconfiguration
        /// </summary>
        private readonly IConfiguration iconfiguration;
        /// <summary>
        /// private User Context
        /// </summary>
        private readonly UserContext userContext;
        /// <summary>
        /// AccountRepository
        /// </summary>
        /// <param name="userContext"></param>
        /// <param name="configuration"></param>
        public AccountRepository(UserContext userContext, IConfiguration configuration)
        {
            this.userContext = userContext;
            this.iconfiguration = configuration;
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
        ///   public string Logout
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public string Logout(LoginModel loginModel)
        {
            try
            {
                var cachekey = loginModel.Email;
                ConnectionMultiplexer connectionMulitplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                IDatabase database = connectionMulitplexer.GetDatabase();
                
                database.KeyDelete(cachekey);
                return "LOGOUT SUCCESSFULLY";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
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
                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(iconfiguration["Jwt:Key"]));
                    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(
                        issuer: iconfiguration["Jwt:Issuer"],
                        audience: iconfiguration["Jwt:Audience"],
                      expires: DateTime.UtcNow.AddMinutes(30),
                      signingCredentials: creds);              
                        
                        var cachekey = loginModel.Email;
                        ConnectionMultiplexer connectionMulitplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                        IDatabase database = connectionMulitplexer.GetDatabase();
                       
                        var data = (new
                          {
                                 token = new JwtSecurityTokenHandler().WriteToken(token),
                                 experation = token.ValidTo
                          });
                        database.StringSet(cachekey, data.ToString());
                        database.StringGet(cachekey);
                        return data.ToString();
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
        /// Facebooks the login asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> FacebookLoginAsync(LoginModel loginModel)
        {
            var result = await this.FindByEmailAsync(loginModel.Email);
            if (result != null)
            {
                bool user = userContext.Register.Any(p => p.Password == loginModel.Password && p.Email == loginModel.Email);
                if (user)
                {
                    try
                    {
                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(iconfiguration["Jwt:Key"]));
                        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                        var token = new JwtSecurityToken(iconfiguration["Jwt:Issuer"],
                          iconfiguration["Jwt:Audience"],
                          expires: DateTime.Now.AddMinutes(30),
                          signingCredentials: creds);

                        var cachekey = loginModel.Email;
                        ConnectionMultiplexer connectionMulitplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                        IDatabase database = connectionMulitplexer.GetDatabase();
                       
                        var data = (new
                        {
                            token = new JwtSecurityTokenHandler().WriteToken(token),
                            experation = token.ValidTo
                        });

                        return data.ToString();
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
        /// Googles the login asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> GoogleLoginAsync(LoginModel loginModel)
        {
            var result = await this.FindByEmailAsync(loginModel.Email);
            if (result != null)
            {
                bool user = userContext.Register.Any(p => p.Password == loginModel.Password && p.Email == loginModel.Email);
                if (user)
                {
                    try
                    {
                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(iconfiguration["Jwt:Key"]));
                        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                        var token = new JwtSecurityToken(iconfiguration["Jwt:Issuer"],
                          iconfiguration["Jwt:Audience"],
                          expires: DateTime.Now.AddMinutes(30),
                          signingCredentials: creds);

                        var cachekey = loginModel.Email;
                        ConnectionMultiplexer connectionMulitplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                        IDatabase database = connectionMulitplexer.GetDatabase();
                        database.StringSet(cachekey, token.ToString());
                        database.StringGet(cachekey);
                        var data = (new
                        {
                            token = new JwtSecurityTokenHandler().WriteToken(token),
                            experation = token.ValidFrom 
                        });

                        return data.ToString();
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