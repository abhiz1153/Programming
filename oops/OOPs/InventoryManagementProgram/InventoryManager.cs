// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace OOPs.InventoryManagementProgram
{
    /// <summary>
    /// Class for Inventory Manager
    /// </summary>
    class InventoryManager
    {
        /// <summary>
        /// Gets the inventory list.
        /// </summary>
        /// <param name="inventorytype">The inventorytype.</param>
        public static void GetInventoryList(string inventoryType)
        {
            try
            {
                InventoryTypes inventoryTypes = InventoryFactory.ReadJsonFile(); 
               
               if(inventoryType.Equals("RICE"))
                {
                    List<RiceClass> riceList = inventoryTypes.RiceList;
                    foreach (RiceClass rice in riceList)
                    {
                        Console.WriteLine("RICE TYPE");
                        Console.WriteLine("Name : " + rice.Name + "\nWeight : " + rice.Weight + " \n Price Per kg " + rice.PricePerKg);
                        Console.WriteLine("Total Price of " + rice.Name + " = " + (rice.Weight * rice.PricePerKg));
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                    }
                    return;
                }
                if (inventoryType.Equals("WHEAT"))
                {
                    List<WheatClass> wheatList = inventoryTypes.WheatList;
                    foreach (WheatClass wheat in wheatList)
                    {
                        Console.WriteLine("WHEAT TYPE");
                        Console.WriteLine("Name : " + wheat.Name + "\nWeight : " + wheat.Weight + " \n Price Per kg " + wheat.PricePerKg);
                        Console.WriteLine("Total Price of " + wheat.Name + " = " + (wheat.Weight * wheat.PricePerKg));
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                    }
                    return;
                }
                if (inventoryType.Equals("PULSE"))
                {
                    List<PulsesClass> pulsesList = inventoryTypes.PulsesList;
                    foreach (PulsesClass pulse in pulsesList)
                    {
                        Console.WriteLine("PULSE TYPE");
                        Console.WriteLine("Name : " +pulse.Name + "\nWeight : " + pulse.Weight + " \n Price Per kg " + pulse.PricePerKg);
                        Console.WriteLine("Total Price of " + pulse.Name + " = " + (pulse.Weight * pulse.PricePerKg));
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
