using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessManager.Interface;
using Common.Models;
using FundooRepository.DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace FundooNoteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccount account;
        readonly Connection connection = new Connection();
        public AccountController(IAccount account)
        {
            this.account = account;
        }
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
    }
}