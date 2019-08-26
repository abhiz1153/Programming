// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountClass.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.CommercialDataProcessing
{
    /// <summary>
    /// Class for Account Class 
    /// </summary>
    public class AccountClass
    {
        /// <summary>
        /// The accountname
        /// </summary>
        private string accountname;
        /// <summary>
        /// The sharenumber
        /// </summary>
        private int sharenumber;
        /// <summary>
        /// The stockprice
        /// </summary>
        private double stockprice;

        /// <summary>
        /// Gets or sets the name of the account.
        /// </summary>
        /// <value>
        /// The name of the account.
        /// </value>
        public string AccountName
        {
            get { return this.accountname; }
            set { this.accountname = value; }
        }
        /// <summary>
        /// Gets or sets the share number.
        /// </summary>
        /// <value>
        /// The share number.
        /// </value>
        public int ShareNumber
        {
            get { return this.sharenumber; }
            set { this.sharenumber = value; }
        }
        /// <summary>
        /// Gets or sets the stock price.
        /// </summary>
        /// <value>
        /// The stock price.
        /// </value>
        public double StockPrice
        {
            get { return this.stockprice; }
            set { this.stockprice = value; }
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountClass"/> class.
        /// </summary>
        /// <param name="accountname">The accountname.</param>
        /// <param name="sharenumber">The sharenumber.</param>
        /// <param name="stockprice">The stockprice.</param>
        public AccountClass(string accountname, int sharenumber, double stockprice)
        {
            this.accountname = accountname;
            this.sharenumber = sharenumber;
            this.stockprice = stockprice;
        }

        /// <summary>
        /// Creates the account object.
        /// </summary>
        /// <param name="accountname">The accountname.</param>
        /// <param name="sharenumber">The sharenumber.</param>
        /// <param name="stockprice">The stockprice.</param>
        public static void CreateAccountObject(string accountname, int sharenumber, double stockprice)
        {
            AccountClass account = new AccountClass(accountname, sharenumber, stockprice);
            NewAccount newAccount = JsonOperation.JsonReadFile();
            newAccount.AccountList.Add(account);
            WriteToFile.WriteDataToFile(newAccount);
            Console.WriteLine("Account Had Been Sucufully Created");
        }

    }
}
