using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models
{
    public class LoginModel
    {
        private string email;
        private string password;
        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }
        public string Password
        {
            set { this.password = value; }
            get { return this.password; }
        }
    }
}
