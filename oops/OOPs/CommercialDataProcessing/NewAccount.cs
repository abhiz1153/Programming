// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NewAccount.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.CommercialDataProcessing
{
    /// <summary>
    /// Class for New Account
    /// </summary>
    class NewAccount
    {
        /// <summary>
        /// The accountlist
        /// </summary>
        private List<AccountClass> accountlist = new List<AccountClass>();
        /// <summary>
        /// Gets or sets the account list.
        /// </summary>
        /// <value>
        /// The account list.
        /// </value>
       public List<AccountClass> AccountList
        {
            get { return this.accountlist; }
            set { this.accountlist = value; }
        }
    }
}
