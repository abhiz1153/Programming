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
       
        [Required(ErrorMessage = "Enter FirstName")]
        public string FirstName
        {
            set { this.firstName = value; }
            get { return this.firstName; }
        }
        [Required(ErrorMessage = "Enter LastName")]
        public string LastName
        {
            set { this.lastName = value; }
            get { return this.lastName; }
        }
        [Key]
        [Required]
        [EmailAddress]
        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }
        [Required(ErrorMessage = "Enter City")]
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
