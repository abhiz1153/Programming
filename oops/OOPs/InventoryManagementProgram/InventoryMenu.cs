// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryMenu.cs" company="Bridgelabz">
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
    /// Calss for Inventory Menu
    /// </summary>
    class InventoryMenu
    {
        public static void InventoryMenuView(string inventoryType)
        {
            try
            {
                char choice;
                int ch;
                do
                {
                    Console.WriteLine("*****IN "+ inventoryType + " WHAT YOU WANT TO PERFORM*****");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("1. To view the Existing Inventory for " + inventoryType);
                    Console.WriteLine("2. To Remove an " + inventoryType + " Item");
                    Console.WriteLine("3. To ADD " + inventoryType + " Item");
                    Console.WriteLine("4. To Edit Existing "+ inventoryType+ " Inventory");
                    Console.WriteLine("5. Back ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Enter your Choice");
                    Console.WriteLine(" ");
                    ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            InventoryManager.GetInventoryList(inventoryType);
                           
                            break;
                        case 2:
                            InputsForInventory.TakeInputForRemovingObject(inventoryType);
                            break;
                        case 3:
                            InputsForInventory.TakeInputsForCreatingObject(inventoryType);
                            break;
                        case 4:
                            InventoryManipulationView.InventoryManipulationview(inventoryType);
                            break;
                        case 5:
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
