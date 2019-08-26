// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CreateAccount.cs" company="Bridgelabz">
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
    /// class for Create Account
    /// </summary>
    class CreateAccount
    {
        /// <summary>
        /// Creates this instance.
        /// </summary>
        public void Create()
        {
            string accountname = null;
            int  sharenumber = 0;
            double stockprice = 0;

            Console.WriteLine("Enter Name to Create an new Account");
             accountname = Console.ReadLine();
            while (true)
            {
               
                if (Utility.ContainsCharacter(accountname))
                {
                    Console.WriteLine("No Character Allowed");
                    continue;
                }

                if (Utility.ContainsDigit(accountname))
                {
                    Console.WriteLine("No Digits Allowed");
                    continue;
                }

                if (Utility.CheckString(accountname))
                {
                    Console.WriteLine("You should Specify a name");
                    continue;
                }

                break;
            }
            sharenumber = 0;
            stockprice = 0;

            AccountClass.CreateAccountObject(accountname, sharenumber, stockprice);

            Console.WriteLine("New Account has Been Created with Name as -" + accountname);


        }
    }
}
