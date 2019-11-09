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
        private string cardType;
        private string profilePicture;
        private int totalNotes;

        
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
        [StringLength(15, MinimumLength = 6, ErrorMessage = "Atlest enter minimum 6 character")]
        public string Password
        {
            set { this.password = value; }
            get { return this.password; }
        }
        public string CardType
        {
            set { this.cardType = value; }
            get { return this.cardType; }
        }
        public string ProfilePicture
        {
            set { this.profilePicture = value; }
            get { return this.profilePicture; }
        }
        public int TotalNotes
        {
            set { this.totalNotes = value; }
            get { return this.totalNotes; }
        }
    }
}
