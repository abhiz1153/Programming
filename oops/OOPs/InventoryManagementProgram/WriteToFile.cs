// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WriteToFile.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPs.InventoryManagementProgram
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// class for write the contents into file
    /// </summary>
    class WriteToFile
    {

       
        /// <summary>
        /// Writes to file.
        /// </summary>
        /// <param name="inventoryTypes">The inventory types.</param>
        public static void WriteDataToFile(InventoryTypes inventoryTypes)
        {
            string path = (Utility.pathData());
           ////Converting InventoryTypes Object to Json String
            string jsonAdddressBook = JsonConvert.SerializeObject(inventoryTypes);
            ////Wrinting Json String to file.
            System.IO.File.WriteAllText(path, jsonAdddressBook);
        }
    }
}
