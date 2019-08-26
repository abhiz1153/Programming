// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserInputsOptions.cs" company="Bridgelabz">
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
    /// Class For User Inputs Options
    /// </summary>
    class UserInputOptions
    {
        /// <summary>
        /// Gets the inputs.
        /// </summary>
        public void GetInputs()
        {
            try
            {
                char choice;
                int ch = 0;
                do
                {
                    Console.WriteLine("****WHAT YOU WANT TO DO******");
                    Console.WriteLine("");
                    Console.WriteLine("1. Create a New Account ");
                    Console.WriteLine("2. Display Total Value of Account Stock");
                    Console.WriteLine("3. ADD Shares and Stock to Account");
                    Console.WriteLine("4. Sell Shares of Stock from Account");
                    Console.WriteLine("5. Display Particular Account Details Reports of Shares and Stocks ");
                    Console.WriteLine("6. Exit");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Enter your choice to perform");
                    ch = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    switch (ch)
                    {
                        //// case 1 for creating an new account
                        case 1:
                            CreateAccount create = new CreateAccount();
                            create.Create();
                                break;
                        //// case 2 for Displaying Total Value of Account Stock
                        case 2:
                            AccountOperation accountDisplay = new AccountOperation();
                            accountDisplay.DisplayTotalStocks();
                            break;
                        //// case 3 for ADDING Shares and Stock to Account
                        case 3:
                            AccountOperation accountbuy = new AccountOperation();
                            accountbuy.Buy();
                            break;
                        //// case 4 for Selling Shares of Stock from Account
                        case 4:
                            AccountOperation accountsell = new AccountOperation();
                            accountsell.Sell();
                            break;
                        case 5:
                            AccountOperation displayaccount = new AccountOperation();
                            displayaccount.DisplayParticularAccount();
                            break;
                        case 6:
                            return;
                    }
                    Console.WriteLine("Do you want to Continue then Press Y");
                    choice = Convert.ToChar(Console.ReadLine());
                }
                while (choice == 'y');
            
                }
            
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
