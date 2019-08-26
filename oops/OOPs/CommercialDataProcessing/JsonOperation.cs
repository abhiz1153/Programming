// --------------------------------------------------------------------------------------------------------------------
// <copyright file="JsonOperation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace OOPs.CommercialDataProcessing
{
    /// <summary>
    /// class for Json Operation
    /// </summary>
    class JsonOperation
    {
        /// <summary>
        /// Jsons the read file.
        /// </summary>
        /// <returns></returns>
        public static NewAccount JsonReadFile()
        {
            //// Json file path
            string path = @"C:\Users\admin\source\repos\OOPs\OOPs\CommercialDataProcessing\AccountStocksFile.json";
            ////checks Wheather File Exist or Not.
            if (File.Exists(path))
            {
                string jsonData = File.ReadAllText(path);

                ////Getting the NewAccount Object from the  JSon String.
                NewAccount accountname = JsonConvert.DeserializeObject<NewAccount>(jsonData);

                return accountname;
            }

            else
            {
                Console.WriteLine("Specified file path does not exist");
                return new NewAccount();
            }

        }
    }
}
