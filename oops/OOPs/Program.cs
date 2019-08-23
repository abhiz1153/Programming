// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace OOPs
{
    /// <summary>
    /// Class for Main Programs
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            try
            {
                char choice;
                int ch;
                do
                {
                    Console.WriteLine("*****Object Oriented Programming Programs*****");
                    Console.WriteLine(" ");
                    Console.WriteLine("1. Inventory Data Management");
                    Console.WriteLine("2. Regular Expression Demonstration ");
                    Console.WriteLine("3. Stock Report");
                    Console.WriteLine("4. Inventory Management Program ");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Enter which program you want to run");
                    Console.WriteLine("");
                    Console.WriteLine("Enter your Choice");
                    Console.WriteLine(" ");
                    ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            InventoryDataManagement.InventoryMain data = new InventoryDataManagement.InventoryMain();
                            data.DisplayAllData();
                            break;
                        case 2:
                            RegularExpression.RegularExpressionMain regularExpression = new RegularExpression.RegularExpressionMain();
                            regularExpression.RegexEep();
                            break;
                        case 3:
                            StockReport.StockReportMain stock = new StockReport.StockReportMain();
                            stock.StockHolder();
                            break;
                        case 4:
                            InventoryManagementProgram.Options options = new InventoryManagementProgram.Options();
                            options.InventoryManagementMethods();
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
