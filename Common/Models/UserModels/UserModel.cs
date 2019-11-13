// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ResetPasswordModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Common.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// public class for UserModel
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// The first name
        /// </summary>
        private string firstName;

        /// <summary>
        /// The last name
        /// </summary>
        private string lastName;

        /// <summary>
        /// The email
        /// </summary>
        private string email;

        /// <summary>
        /// The city
        /// </summary>
        private string city;

        /// <summary>
        /// The password
        /// </summary>
        private string password;

        /// <summary>
        /// The card type
        /// </summary>
        private string cardType;

        /// <summary>
        /// The profile picture
        /// </summary>
        private string profilePicture;

        /// <summary>
        /// The total notes
        /// </summary>
        private int totalNotes;

        /// <summary>
        /// The status
        /// </summary>
        private string status;

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName
        {
            set { this.firstName = value; }
            get { return this.firstName; }
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [Required(ErrorMessage = "Enter LastName")]
        public string LastName
        {
            set { this.lastName = value; }
            get { return this.lastName; }
        }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [Key]
        [Required]
        [EmailAddress]
        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        [Required(ErrorMessage = "Enter City")]
        public string City
        {
            set { this.city = value; }
            get { return this.city; }
        }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [Required(ErrorMessage = "Enter Passsword")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "Atlest enter minimum 6 character")]
        public string Password
        {
            set { this.password = value; }
            get { return this.password; }
        }

        /// <summary>
        /// Gets or sets the type of the card.
        /// </summary>
        /// <value>
        /// The type of the card.
        /// </value>
        public string CardType
        {
            set { this.cardType = value; }
            get { return this.cardType; }
        }

        /// <summary>
        /// Gets or sets the profile picture.
        /// </summary>
        /// <value>
        /// The profile picture.
        /// </value>
        public string ProfilePicture
        {
            set { this.profilePicture = value; }
            get { return this.profilePicture; }
        }

        /// <summary>
        /// Gets or sets the total notes.
        /// </summary>
        /// <value>
        /// The total notes.
        /// </value>
        public int TotalNotes
        {
            set { this.totalNotes = value; }
            get { return this.totalNotes; }
        }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string Status
        {
            set { this.status = value; }
            get { return this.status; }
        }
    }
}
