// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryModels.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------

namespace OOPs.InventoryDataManagement
{
    /// <summary>
    /// Public Class for Inventory Details
    /// </summary>
    public class InventoryModels
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
        /// The priceperkg
        /// </summary>
        private double priceperkg;
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
            get { return this.priceperkg; }
            set { this.priceperkg = value; }
        }
    }
}

