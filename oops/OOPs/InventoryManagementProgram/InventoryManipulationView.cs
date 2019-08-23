// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryManipulationView.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPs.InventoryManagementProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class InventoryManipulationView
    /// </summary>
    public class InventoryManipulationView
    {
        /// <summary>
        /// Inventories the manipulation view.
        /// </summary>
        /// <param name="inventoryType">Type of the inventory.</param>
        public static void InventoryManipulationview(string inventoryType)
        {
            Console.WriteLine("Enter the Item Name you Want to Edit");
            string itemName = Console.ReadLine();

            if (inventoryType.Equals("RICE"))
            {
                if (RiceClass.DoesObjectExist(itemName) == false)
                {
                    Console.WriteLine("item " + itemName + " does not exist");
                    return;
                }
            }

            if (inventoryType.Equals("WHEAT"))
            {
                if (WheatClass.DoesObjectExist(itemName) == false)
                {
                    Console.WriteLine("item " + itemName + " does not exist");
                    return;
                }
            }

            if (inventoryType.Equals("PULSES"))
            {
                if (PulsesClass.DoesObjectExist(itemName) == false)
                {
                    Console.WriteLine("item " + itemName + " does not exist");
                    return;
                }
            }

            EditMenu(inventoryType, itemName);
        }

        /// <summary>
        /// Edits the menu.
        /// </summary>
        /// <param name="inventoryType">Type of the inventory.</param>
        /// <param name="itemName">Name of the item.</param>
        public static void EditMenu(string inventoryType, string itemName)
        {
            while (true)
            {
                Console.WriteLine("Choose what do you want to edit");
                Console.WriteLine("0) To Go Back");
                Console.WriteLine("1) Name");
                Console.WriteLine("2) Weight");
                Console.WriteLine("3) Price Per Kg");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "0":
                        {
                            return;
                        }

                    case "1":
                        {
                            InventoryManupulation.ChangeName(inventoryType, itemName);
                            break;
                        }

                    case "2":
                        {
                            InventoryManupulation.ChangeWeight(inventoryType, itemName);
                            break;
                        }

                    case "3":
                        {
                            InventoryManupulation.ChangePrice(inventoryType, itemName);
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid Input");
                            break;
                        }
                }
            }
        }
    }
}