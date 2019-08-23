// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryManupulation.cs" company="Bridgelabz">
// Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPs.InventoryManagementProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class InventoryManuPulation
    /// </summary>
    public class InventoryManupulation
    {
        /// <summary>
        /// Makes the changes.
        /// </summary>
        /// <param name="inventoryType">Type of the inventory.</param>
        /// <param name="itemName">Name of the item.</param>
        public static void ChangeName(string inventoryType, string itemName)
        {
            string newName;
            while (true)
            {
                Console.WriteLine("Enter the New name for " + inventoryType);
                newName = Console.ReadLine();

                if (Utility.ContainsCharacter(newName))
                {
                    Console.WriteLine("No Character Allowed");
                    continue;
                }

                if (Utility.ContainsDigit(newName))
                {
                    Console.WriteLine("No Digits Allowed");
                    continue;
                }

                if (Utility.CheckString(newName))
                {
                    Console.WriteLine("You should Specify a name");
                    continue;
                }

                break;
            }

            InventoryTypes inventoryTypes = InventoryFactory.ReadJsonFile();

            if (inventoryType.Equals("RICE"))
            {
                List<RiceClass> riceList = inventoryTypes.RiceList;

                foreach (RiceClass rice in riceList)
                {
                    if (rice.Name.Equals(itemName))
                    {
                        rice.Name = newName;
                        break;
                    }
                }

                WriteToFile.WriteDataToFile(inventoryTypes);
                Console.WriteLine("Updated successfully");
            }

            if (inventoryType.Equals("WHEAt"))
            {
                List<WheatClass> wheatList = inventoryTypes.WheatList;

                foreach (WheatClass wheat in wheatList)
                {
                    if (wheat.Name.Equals(itemName))
                    {
                        wheat.Name = newName;
                        break;
                    }
                }

                WriteToFile.WriteDataToFile(inventoryTypes);
                Console.WriteLine("Updated successfully");
            }

            if (inventoryType.Equals("PULSES"))
            {
                List<PulsesClass> pulseList = inventoryTypes.PulsesList;

                foreach (PulsesClass pulse in pulseList)
                {
                    if (pulse.Name.Equals(itemName))
                    {
                        pulse.Name = newName;
                        break;
                    }
                }

                WriteToFile.WriteDataToFile(inventoryTypes);
                Console.WriteLine("Updated successfully");
            }
        }

        /// <summary>
        /// Changes the weight.
        /// </summary>
        /// <param name="inventoryType">Type of the inventory.</param>
        /// <param name="itemName">Name of the item.</param>
        public static void ChangeWeight(string inventoryType, string itemName)
        {
            double newWeight;
            InventoryTypes inventoryTypes = InventoryFactory.ReadJsonFile();

            while (true)
            {
                Console.WriteLine("Enter the Weight");
                string stringWeight = Console.ReadLine();

                try
                {
                    newWeight = Convert.ToDouble(stringWeight);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input For Weight");
                    continue;
                }
            }

            if (inventoryType.Equals("RICE"))
            {
                List<RiceClass> riceList = inventoryTypes.RiceList;

                foreach (RiceClass rice in riceList)
                {
                    if (rice.Name.Equals(itemName))
                    {
                        rice.Weight = newWeight;
                        break;
                    }
                }

                WriteToFile.WriteDataToFile(inventoryTypes);
                Console.WriteLine("Updated successfully");
            }

            if (inventoryType.Equals("WHEAt"))
            {
                List<WheatClass> wheatList = inventoryTypes.WheatList;

                foreach (WheatClass wheat in wheatList)
                {
                    if (wheat.Name.Equals(itemName))
                    {
                        wheat.Weight = newWeight;
                        break;
                    }
                }

                WriteToFile.WriteDataToFile(inventoryTypes);
                Console.WriteLine("Updated successfully");
            }

            if (inventoryType.Equals("PULSES"))
            {
                List<PulsesClass> pulseList = inventoryTypes.PulsesList;

                foreach (PulsesClass pulse in pulseList)
                {
                    if (pulse.Name.Equals(itemName))
                    {
                        pulse.Weight = newWeight;
                        break;
                    }
                }

                WriteToFile.WriteDataToFile(inventoryTypes);
                Console.WriteLine("Updated successfully");
            }
        }

        /// <summary>
        /// Changes the price.
        /// </summary>
        /// <param name="inventoryType">Type of the inventory.</param>
        /// <param name="itemName">Name of the item.</param>
        public static void ChangePrice(string inventoryType, string itemName)
        {
            double newPricePerKG;
            InventoryTypes inventoryTypes = InventoryFactory.ReadJsonFile();

            while (true)
            {
                Console.WriteLine("Specify Price per Kg");
                string stringPrice = Console.ReadLine();
                try
                {
                    newPricePerKG = Convert.ToDouble(stringPrice);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input For Price Per KG");
                    continue;
                }
            }

            if (inventoryType.Equals("RICE"))
            {
                List<RiceClass> riceList = inventoryTypes.RiceList;

                foreach (RiceClass rice in riceList)
                {
                    if (rice.Name.Equals(itemName))
                    {
                        rice.PricePerKg = newPricePerKG;
                        break;
                    }
                }

                WriteToFile.WriteDataToFile(inventoryTypes);
                Console.WriteLine("Updated successfully");
            }

            if (inventoryType.Equals("WHEAt"))
            {
                List<WheatClass> wheatList = inventoryTypes.WheatList;

                foreach (WheatClass wheat in wheatList)
                {
                    if (wheat.Name.Equals(itemName))
                    {
                        wheat.PricePerKg = newPricePerKG;
                        break;
                    }
                }

                WriteToFile.WriteDataToFile(inventoryTypes);
                Console.WriteLine("Updated successfully");
            }

            if (inventoryType.Equals("PULSES"))
            {
                List<PulsesClass> pulseList = inventoryTypes.PulsesList;

                foreach (PulsesClass pulse in pulseList)
                {
                    if (pulse.Name.Equals(itemName))
                    {
                        pulse.PricePerKg = newPricePerKG;
                        break;
                    }
                }

                WriteToFile.WriteDataToFile(inventoryTypes);
                Console.WriteLine("Updated successfully");
            }
        }
    }
}