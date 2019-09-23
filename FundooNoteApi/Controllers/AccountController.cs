// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooNoteApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BussinessManager.Interface;
    using Common.Models;
    using FundooRepository.DBContext;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
    /// <summary>
    ///  public class AccountController
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />

    [Route("api/[controller]")]
    [Route("api/")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        /// <summary>
        /// The account
        /// </summary>
        private readonly IAccount account;
        /// <summary>
        /// The connection
        /// </summary>
        //readonly Connection connection = new Connection();
       // readonly Connection connection = new Connection();
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountController"/> class.
        /// </summary>
        /// <param name="account">The account.</param>
        public AccountController(IAccount account)
        {
            this.account = account;
        }
        /// <summary>  
        /// <summary>
        /// Registrations the specified user model.
        /// </summary>
        /// <param name="userModel">The user model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Registration(UserModel userModel)
        {
            try
            {

                var result = await this.account.RegistrationAsync(userModel);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Logins the specified login model.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            try
            {
                var result = await this.account.LoginAsync(loginModel);
                return this.Ok(new { result });
            }
            catch (Exception e)
             {
                return this.BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("facebooklogin")]
        public async Task<IActionResult> FacebookLogin(LoginModel loginModel)
        {
            try
            {
                var result = await this.account.FacebookLoginAsync(loginModel);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("resetpassword")]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel resetPasswordModel)
        {
            try
            {
                var result = await this.account.ResetPasswordAsync(resetPasswordModel);
                return this.Ok(new { result });
            }
            catch(Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Forgets the password.
        /// </summary>
        /// <param name="forgetPasswordModel">The forget password model.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("forgetpassword")]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordModel forgetPasswordModel)
        {
            try
            {
                var result = await this.account.ForgetPasswordLinkAsync(forgetPasswordModel);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }

        }
    }
}