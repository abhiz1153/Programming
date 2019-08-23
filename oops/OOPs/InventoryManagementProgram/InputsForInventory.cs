// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InputsForInventory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPs.InventoryManagementProgram
{
    using System;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Inputs for Inventory
    /// </summary>
    public class InputsForInventory
    {
        /// <summary>
        /// Takes input
        /// </summary>
        /// <param name="inventoryType">inventory Type</param>
        public static void TakeInputsForCreatingObject(string inventoryType)
        {
            string name = null;
            double weight = 0;
            double pricePerKG = 0;

            while (true)
            {
                Console.WriteLine("Enter the Name for " + inventoryType);
                name = Console.ReadLine();

                if (Utility.ContainsCharacter(name))
                {
                    Console.WriteLine("No Character Allowed");
                    continue;
                }

                if (Utility.ContainsDigit(name))
                {
                    Console.WriteLine("No Digits Allowed");
                    continue;
                }

                if (Utility.CheckString(name))
                {
                    Console.WriteLine("You should Specify a name");
                    continue;
                }

                break;
            }

            while (true)
            {
                Console.WriteLine("Enter the Weight");
                string stringWeight = Console.ReadLine();

                try
                {
                    weight = Convert.ToDouble(stringWeight);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input For Weight");
                    continue;
                }
            }

            while (true)
            {
                Console.WriteLine("Specify Price per Kg");
                string stringPrice = Console.ReadLine();
                try
                {
                    pricePerKG = Convert.ToDouble(stringPrice);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input For Price Per KG");
                    continue;
                }
            }

            //// Checks For Which Inventory Item Object should be created.
            if (inventoryType.Equals("RICE"))
            {
                RiceClass.CreateRiceObject(name, weight, pricePerKG);
            }

            //// Checks For Which Inventory Item Object should be created.
            if (inventoryType.Equals("WHEAT"))
            {
                WheatClass.CreateWheatObject(name, weight, pricePerKG);
            }

            //// Checks For Which Inventory Item Object should be created.
            if (inventoryType.Equals("PULSES"))
            {
                PulsesClass.CreatePulsesObject(name, weight, pricePerKG);
            }
        }

        /// <summary>
        /// Takes Input necessary for Removing a object from inventory.
        /// </summary>
        /// <param name="inventoryType">inventory type</param>
        public static void TakeInputForRemovingObject(string inventoryType)
        {
            while (true)
            {
                Console.WriteLine("Enter the Item name you want to remove ");
                string itemName = Console.ReadLine();

                if (!Regex.IsMatch(itemName, "^[a-zA-Z]+$"))
                {
                    Console.WriteLine("Invalid input ");
                    continue;
                }

                if (inventoryType.Equals("RICE"))
                {
                    RiceClass.RemoveRiceObject(itemName);
                }

                if (inventoryType.Equals("WHEAT"))
                {
                    WheatClass.RemoveWheatObject(itemName);
                }

                if (inventoryType.Equals("PULSES"))
                {
                    PulsesClass.RemovePulseObject(itemName);
                }

                break;
            }
        }
    }
}