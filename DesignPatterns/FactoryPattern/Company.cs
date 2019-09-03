// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Company.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.FactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class for Company which Holds details of Company Accounts Details
    /// </summary>
    class Company
    {
        /// <summary>
        /// Companies the account sections.
        /// </summary>
        public void CompanyAccountSections()
        {
            try
            {
                char choice;
                int choose;
                do
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("*****ACCOUNTS DEPARTMENT SECTIONS*****");
                    Console.WriteLine("***********MONTHLY PAYMENTS***********");
                    Console.WriteLine("1. Sales Manager");
                    Console.WriteLine("2. Production Manager");
                    Console.WriteLine("3. Operator");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Enter Whose Payment you want to do");
                    Console.WriteLine(" ");
                    choose = Convert.ToInt32(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:
                            Payments payment1 = new Payments();
                            payment1.Sales();
                            break;
                        case 2:
                            Payments payment2 = new Payments();
                            payment2.Production();
                            break;
                        case 3:
                            Payments payment3 = new Payments();
                            payment3.OperatorEmployee();
                            break;

                    }
                    Console.WriteLine("Do you want to Continue then Press Y");
                    choice = Convert.ToChar(Console.ReadLine());
                }
                while (choice == 'y');
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
