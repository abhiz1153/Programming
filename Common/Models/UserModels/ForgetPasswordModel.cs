// ----------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=ForgetPasswordModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// ----------------------------------------------------------------------------------------------------------------------------------------------------------
namespace Common.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// public class ForgetPasswordModel
    /// </summary>
    public class ForgetPasswordModel    
    {
        /// <summary>
        /// The email
        /// </summary>
        private string email;
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }
    }
}
