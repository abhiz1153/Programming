// --------------------------------------------------------------------------------------------------------------------
// <copyright file=" Options.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.InventoryManagementProgram
{
    /// <summary>
    /// Class for Options
    /// </summary>
    class Options
    {
        /// <summary>
        /// Public class for Inventories the management methods.
        /// </summary>
        public void InventoryManagementMethods()
        {
            try
            {
                char choice;
                int ch;
                do
                {
                    Console.WriteLine("*****WHAT YOU WANT*****");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("1. Rice ");
                    Console.WriteLine("2. Wheat");
                    Console.WriteLine("3. Pulse");
                    Console.WriteLine("4. Exit ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Enter your Choice");
                    Console.WriteLine(" ");
                    ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            InventoryMenu.InventoryMenuView("RICE");
                            break;
                        case 2:
                            InventoryMenu.InventoryMenuView("WHEAT");
                            break;
                        case 3:
                            InventoryMenu.InventoryMenuView("PULSE");
                            break;
                        case 4:
                            return;
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