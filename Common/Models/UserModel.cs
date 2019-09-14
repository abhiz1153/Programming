using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.Models
{
    public class UserModel
    {
        
        private string firstName;
        private string lastName;
        private string email;
        private string city;
        private string password;
       
        public string FirstName
        {
            set { this.firstName = value; }
            get { return this.firstName; }
        }
        public string LastName
        {
            set { this.lastName = value; }
            get { return this.lastName; }
        }
        [Key]
        [Required(ErrorMessage = "Enter Email")]
        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }
       
        public string City
        {
            set { this.city = value; }
            get { return this.city; }
        }
        [Required(ErrorMessage = "Enter Passsword")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "Atlest enter minimum 8 character")]
        public string Password
        {
            set { this.password = value; }
            get { return this.password; }
        }
    }
}
