// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockReportMain.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OOPs.StockReport
{
    /// <summary>
    /// Class for Stock Main
    /// </summary>
   public class StockReportMain
    {
        /// <summary>
        /// Stocks the holder.
        /// </summary>
        public void StockHolder()
        {
            try
            {
                double totalstockcost = 0;
                //Json file path
                string path = @"C:\Users\admin\source\repos\OOPs\OOPs\StockReport\StockDetails.json";
                //Serializing Json Object
                StreamReader read = new StreamReader(path);
                //Reads all characters from the current position to the end
                var json = read.ReadToEnd();
                //Deserializing Json Object
                StockModel[] items = JsonConvert.DeserializeObject<StockModel[]>(json);
                Console.WriteLine("");
                Console.WriteLine("Stocks Details for Vehicles ");
                Console.WriteLine("");
                Console.WriteLine("");
                
                for(int i=0;i<items.Length;i++)
                {
                    Console.WriteLine("Stock Name :- " + items[i].StockName);
                    Console.WriteLine("Share Number :- " + items[i].ShareNumber);
                    Console.WriteLine("Each Stock Cost :- Rs. " + items[i].StockPrice);
                    Console.WriteLine("Total cost for " + items[i].StockName + " :- Rs. " + (items[i].ShareNumber * items[i].StockPrice));
                    Console.WriteLine("");
                    Console.WriteLine("");
                    totalstockcost = totalstockcost + (items[i].StockPrice * items[i].ShareNumber);
                }
                Console.WriteLine("Total Cost for All Stock = Rs. " + totalstockcost);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}