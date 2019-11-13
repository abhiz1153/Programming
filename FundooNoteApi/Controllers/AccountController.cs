// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace FundooNoteApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using BussinessManager.Interface;
    using Common.Models;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

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
        /// <returns>IActionResult</returns>
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
        /// <returns>IActionResult</returns>
        [HttpPost]
        [Route("login")]
        public async Task<UserModel> Login(LoginModel loginModel)
        {
            var result = await this.account.LoginAsync(loginModel);
            return result;
        }

        /// <summary>
        /// Facebooks the login.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns>IActionResult</returns>
        [HttpPost]
        [Route("facebooklogin")]
        public async Task<UserModel> FacebookLogin(LoginModel loginModel)
        {

            var result = await this.account.FacebookLoginAsync(loginModel);
            return result;
        }

        /// <summary>
        /// Googles the login.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns>IActionResult</returns>
        [HttpPost]
        [Route("google")]
        public async Task<UserModel> GoogleLogin(LoginModel loginModel)
        {
            var result = await this.account.GoogleLoginAsync(loginModel);
            return result;
        }
        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <returns>IActionResult</returns>
        [HttpPut]
        [Route("resetpassword")]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel resetPasswordModel)
        {
            try
            {
                var result = await this.account.ResetPasswordAsync(resetPasswordModel);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Forgets the password.
        /// </summary>
        /// <param name="forgetPasswordModel">The forget password model.</param>
        /// <returns>IActionResult</returns>
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

        /// <summary>
        /// Logouts the specified login model.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns>IActionResult</returns>
        [HttpPost]
        [Route("logout")]
        public string Logout(LoginModel loginModel)
        {
            var result = this.account.LogoutAsync(loginModel);
            return result;
        }

        /// <summary>
        /// Uploads the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="profilePicture">The profile picture.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("upload")]
        public IActionResult Upload(string email, IFormFile profilePicture)
        {
            try
            {
                var result = this.account.UploadImages(email, profilePicture);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Users the list.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("viewall")]
        public List<UserModel> UserList()
        {
            return this.account.GetAllUserListAsync();
        }
    }
}