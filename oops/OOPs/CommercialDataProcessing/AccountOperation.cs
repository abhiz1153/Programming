// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountOperation.cs" company="Bridgelabz">
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
    /// Class for Account Operation
    /// </summary>
    class AccountOperation
    {
        /// <summary>
        /// Displays the total stocks.
        /// </summary>
        public void DisplayTotalStocks()
        {
            NewAccount newAccount = JsonOperation.JsonReadFile();
            List<AccountClass> accountlist = newAccount.AccountList;
            double sum = 0;
            foreach (var account in accountlist)
            {
                Console.WriteLine(" ");
                Console.WriteLine(" Account Name : " + account.AccountName + "\n Share Number : " + account.ShareNumber + " \n Stock Price :" + account.StockPrice);
                //            Console.WriteLine("Total Stocks Price of " +  + " = " + (rice.Weight * rice.PricePerKg));
                Console.WriteLine(" ");

                sum += account.StockPrice;
            }
            Console.WriteLine("Total Value of Accounts store in Database - Rs. " + sum);
        }
        /// <summary>
        /// Displays the particular account.
        /// </summary>
      public void DisplayParticularAccount()
        {
            string accountname;
            while (true)
            {

                Console.WriteLine("Enter the Account Name For wich you want to Buy");
                accountname = Console.ReadLine();

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
                NewAccount newAccount = JsonOperation.JsonReadFile();
                List<AccountClass> accountlist = newAccount.AccountList;

                foreach (AccountClass name in accountlist)
                {
                    if (name.AccountName.Equals(accountname))
                    {
                        Console.WriteLine("Account Name : " + name.AccountName + "\n Share Number : " + name.ShareNumber + " \n Stock Price :" + name.StockPrice);

                    }
                }
                break;
            }     
        }
        /// <summary>
        /// Buys this instance.
        /// </summary>
        public void Buy()
        {
            string accountname;
            while (true)
            {
                Console.WriteLine("Enter the Account Name For which you want to Buy");
                accountname = Console.ReadLine();

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
                NewAccount newAccount = JsonOperation.JsonReadFile();
                List<AccountClass> accountlist = newAccount.AccountList;

                foreach (AccountClass name in accountlist)
                {
                    if (name.AccountName.Equals(accountname))
                    {
                        Console.WriteLine("Enter the Number Share you want to buy");
                        int number = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the Stock Price you want to buy");
                        double price = Convert.ToDouble(Console.ReadLine());

                        name.ShareNumber = name.ShareNumber + number;

                        name.StockPrice = name.StockPrice + price;

                    }
                    WriteToFile.WriteDataToFile(newAccount);

                }
                Console.WriteLine(accountname + " had Successfully Buy their Share and Stock Price");
                break;

            }
        }
        /// <summary>
        /// Sells this instance.
        /// </summary>
        public void Sell()
        {
            string accountname;
            while (true)
            {
                Console.WriteLine("Enter the Account Name For wich you want to Sell");
                accountname = Console.ReadLine();

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
                NewAccount newAccount = JsonOperation.JsonReadFile();
                List<AccountClass> accountlist = newAccount.AccountList;

                foreach (AccountClass name in accountlist)
                {
                    if (name.AccountName.Equals(accountname))
                    {
                        Console.WriteLine("Enter the Share you want to Sell");
                        int number = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the Stock you want to Sell");
                        double price = Convert.ToDouble(Console.ReadLine());

                        name.ShareNumber = name.ShareNumber - number;

                        name.StockPrice = name.StockPrice - price;

                    }
                    WriteToFile.WriteDataToFile(newAccount);

                }

                Console.WriteLine(accountname + " had Successfully Sell their Share and Stock Price");
                break;
            }
        }
    }
}