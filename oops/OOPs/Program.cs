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
                    Console.WriteLine("5. Commercial Data Processing");
                    Console.WriteLine("6. Deck Of Card ");
                    Console.WriteLine("7. Deck of Card Using Queue");
                    Console.WriteLine("8. Address Book");
                    Console.WriteLine("");
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
                        case 5:
                            CommercialDataProcessing.UserInputOptions userInputOptions = new CommercialDataProcessing.UserInputOptions();
                            userInputOptions.GetInputs();
                            break;
                        case 6:
                            DeckOfCards.DeckOfCards cards = new DeckOfCards.DeckOfCards();
                            cards.InitializeCard();
                            break;
                        case 7:
                            DeckOfCards.DeckOfCardsUsingQueue queue = new DeckOfCards.DeckOfCardsUsingQueue();
                            queue.InitializeDeckOfCardsUsingQueue();
                            break;
                        case 8:
                            AddressBookFolder.Choice address = new AddressBookFolder.Choice();
                            address.Options();
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
