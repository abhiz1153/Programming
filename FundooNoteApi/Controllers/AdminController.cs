// ----------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=AdminController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// ----------------------------------------------------------------------------------------------------------------------------------------------------------
namespace FundooNoteApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using BussinessManager.Interface;
    using Common.Models.AdminModels;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Public class Controller for AdminController
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        /// <summary>
        /// The admin
        /// </summary>
        private readonly IAdmin admin;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminController"/> class.
        /// </summary>
        /// <param name="admin">The admin.</param>
        public AdminController(IAdmin admin)
        {
            this.admin = admin;
        }

        /// <summary>
        /// Adds the admin asynchronous.
        /// </summary>
        /// <param name="adminLogin">The admin login.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpPost]
        [Route("add")]
        public  IActionResult AddAdminAsync(AdminLoginModel adminLogin)
        {
            try
            {
                var result = this.admin.AddAdminAsync(adminLogin);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Logins the asynchronous.
        /// </summary>
        /// <param name="adminLogin">The admin login.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LoginAsync(AdminLoginModel adminLogin)
        {
            try
            {
                var result = await this.admin.AdminLoginAsync(adminLogin);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Lists this instance.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("loginlist")]
        public List<AdminModel> List()
        {
            return this.admin.GetAllListAsync();
        }
    }
}