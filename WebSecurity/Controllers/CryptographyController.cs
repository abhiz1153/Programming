using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSecurity.Repository;

namespace WebSecurity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CryptographyController : ControllerBase
    {
        private readonly Cryptography cryptography;
        public CryptographyController(Cryptography cryptography)
        {
            this.cryptography = cryptography;
        }
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> EncryptData(string Data)
        {
            try
            {
                var result = await this.cryptography.GenerateToken(Data);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        [HttpGet]
        [Route("view")]
        public IActionResult viewData()
        {
            try
            {
                string result = User.Claims.First(c => c.Type == ClaimTypes.UserData).Value;
                return Ok(new { result });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        [HttpPost]
        [Route("encrypt")]
        public async Task<IActionResult> EncryptionData(string text, string keyString)
        {
            try
            {
                var result = await this.cryptography.EncryptString(text, keyString);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        [HttpPut]
        [Route("decrypt")]
        public async Task<IActionResult> DecryptionData(string cipherText, string keyString)
        {
            try
            {
                var result = await this.cryptography.DecryptString(cipherText, keyString);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}