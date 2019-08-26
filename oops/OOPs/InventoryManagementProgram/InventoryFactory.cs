// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPs.InventoryManagementProgram
{
    using System;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// Inventory Factory Class For Read File
    /// </summary>
    public class InventoryFactory
    {
        

        /// <summary>
        /// Reads the json file.
        /// </summary>
        /// <returns>returns Inventory details</returns>
        public static InventoryTypes ReadJsonFile()
        {
            string path = Utility.pathData();
            ////checks Wheather File Exist or Not.
            if (File.Exists(path))
            {
                string jsonData = File.ReadAllText(path);

                ////Getting the inventoryTypes Object from the  JSon String.
                InventoryTypes jsonObjectArray = JsonConvert.DeserializeObject<InventoryTypes>(jsonData);

                return jsonObjectArray;
            }
            else 
            {
                Console.WriteLine("Specified file path does not exist");
                return new InventoryTypes();
            }
        }
    }
}
