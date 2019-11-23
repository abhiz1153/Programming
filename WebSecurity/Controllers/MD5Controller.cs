using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSecurity.Repository;

namespace WebSecurity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MD5Controller : ControllerBase
    {
        private readonly MD5Implement mD5Implement;
        public MD5Controller(MD5Implement mD5Implement)
        {
            this.mD5Implement = mD5Implement;
        }
        [HttpPost]
        [Route("encrypt")]
        public async Task<IActionResult> EncryptionData(string text)
        {
            try
            {
                var result = await this.mD5Implement.MD5Encryption(text);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}