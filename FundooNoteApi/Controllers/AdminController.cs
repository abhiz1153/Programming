using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessManager.Interface;
using Common.Models.AdminModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FundooNoteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdmin admin;
        public AdminController(IAdmin admin)
        {
            this.admin = admin;
        }
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
        [HttpGet]
        [Route("loginlist")]
        public List<AdminModel> List()
        {
            return this.admin.GetAllListAsync();
        }
    }
}