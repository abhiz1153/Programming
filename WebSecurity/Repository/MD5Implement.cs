using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace WebSecurity.Repository
{
    public class MD5Implement
    {
        public Task<string> MD5Encryption(string text)
        {
            using (var md5 = MD5.Create())
            {
                byte[] textBytes = Encoding.ASCII.GetBytes(text);
                byte[] hash = md5.ComputeHash(textBytes);
                var stringBuilder = new StringBuilder();
                for(int i = 0; i< hash.Length; i++)
                {
                    stringBuilder.Append(hash[i].ToString());
                }
                return Task.Run(() => stringBuilder.ToString());
            }
        }     
    }
}
