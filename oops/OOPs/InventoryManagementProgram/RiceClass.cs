// <copyright file="RiceClass.cs" company="Bridgelabz">
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
    /// class for rice
    /// </summary>
    public class RiceClass
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The weight
        /// </summary>
        private double weight;

        /// <summary>
        /// The price per kg
        /// </summary>
        private double pricePerKG;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rice"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="pricePerKG">The price per kg.</param>
        public RiceClass(string name, double weight, double pricePerKG)
        {
            this.name = name;
            this.weight = weight;
            this.pricePerKG = pricePerKG;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        /// <summary>
        /// Gets or sets the price per kg.
        /// </summary>
        /// <value>
        /// The price per kg.
        /// </value>
        public double PricePerKg
        {
            get { return this.pricePerKG; }
            set { this.pricePerKG = value; }
        }

        /// <summary>
        /// Creates the rice object.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="pricePerKG">The price per kg.</param>
        public static void CreateRiceObject(string name, double weight, double pricePerKG)
        {
            RiceClass rice = new RiceClass(name, weight, pricePerKG);
            InventoryTypes inventoryTypes = InventoryFactory.ReadJsonFile();
            inventoryTypes.RiceList.Add(rice);
            WriteToFile.WriteDataToFile(inventoryTypes);
            Console.WriteLine("Added To inventory Succefully");
        }

        /// <summary>
        /// Removes the rice object.
        /// </summary>
        /// <param name="itemName">Name of the item.</param>
        public static void RemoveRiceObject(string itemName)
        {
            InventoryTypes inventoryTypes = InventoryFactory.ReadJsonFile();
            List<RiceClass> riceList = inventoryTypes.RiceList;

            foreach (RiceClass rice in riceList)
            {
                if (rice.Name.Equals(itemName))
                {
                    riceList.Remove(rice);
                    WriteToFile.WriteDataToFile(inventoryTypes);
                    Console.WriteLine("Item " + itemName + "removed Successfully");
                    Console.WriteLine("--------------------------------------------");
                    return;
                }
            }

            Console.WriteLine("Item " + itemName + "to be removed not found");
        }

        /// <summary>
        /// Does the object exist.
        /// </summary>
        /// <param name="itemName">Name of the item.</param>
        /// <returns>returns true or false</returns>
        public static bool DoesObjectExist(string itemName)
        {
            InventoryTypes inventoryTypes = InventoryFactory.ReadJsonFile();
            List<RiceClass> riceList = inventoryTypes.RiceList;

            foreach (RiceClass rice in riceList)
            {
                if (rice.Name.Equals(itemName))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return "Name  : " + this.Name + "\nWeight : " + this.Weight + "\nPrice Per Kg : " + this.pricePerKG;
        }
    }
}