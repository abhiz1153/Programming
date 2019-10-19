// ----------------------------------------------------------------------------------------------------------------------------------
// <copyright file=AdminLoginModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// ----------------------------------------------------------------------------------------------------------------------------------
namespace Common.Models.AdminModels
{
    using System.ComponentModel.DataAnnotations;
    /// <summary>
    ///   public class AdminLoginModel
    /// </summary>
    public class AdminLoginModel
    {
        /// <summary>
        /// The email
        /// </summary>
        private string email;
        /// <summary>
        /// The first name
        /// </summary>
        private string firstName;
        /// <summary>
        /// The last name
        /// </summary>
        private string lastName;
        /// <summary>
        /// The password
        /// </summary>
        private string password;
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [Key]
        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
         }
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
        public string LastName
        {
            set { this.lastName = value; }
            get { return this.lastName; }
        }
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password
        {
            set { this.password = value; }
            get { return this.password; }
        }
    }
}
