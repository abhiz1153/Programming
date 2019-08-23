// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryMain.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OOPs.InventoryDataManagement
{
    /// <summary>
    /// Class For Display
    /// </summary>
    class InventoryMain
    {
        /// <summary>
        /// Displays all data.
        /// </summary>
        public void DisplayAllData()
        {
            try
            {
                //Json file path
                string path = (@"C:\Users\admin\source\repos\OOPs\OOPs\InventoryDataManagement\InventoryFile.json");
                //Serializing Json Object
                StreamReader read = new StreamReader(path);
                //Reads all characters from the current position to the end
                var json = read.ReadToEnd();
                //Deserializing Json Object
                var items = JsonConvert.DeserializeObject<List<InventoryModels>>(json);

                Console.WriteLine("Name\tWeight\tRate(Per kg)\tAmount");
                foreach (var item in items)
                {
                    Console.WriteLine(item.Name + "\t" + item.Weight + "\t" + item.PricePerKg + "\t\t" + (item.Weight * item.PricePerKg));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
