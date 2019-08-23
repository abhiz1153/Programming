// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.StockReport
{
    /// <summary>
    /// Public Class for Stock Model
    /// </summary>
    public class StockModel
    {
        /// <summary>
        /// The name
        /// </summary>
        private string stockname;
        /// <summary>
        /// The number
        /// </summary>
        private int sharenumber;
        /// <summary>
        /// The price
        /// </summary>
        private double stockprice;
        /// <summary>
        /// Gets or sets the name of the stock.
        /// </summary>
        /// <value>
        /// The name of the stock.
        /// </value>
        public string StockName
        {
            get { return this.stockname; }
            set { this.stockname = value; }
        }
        /// <summary>
        /// Gets or sets the share number.
        /// </summary>
        /// <value>
        /// The share number.
        /// </value>
        public int ShareNumber
        {
            get { return this.sharenumber; }
            set { this.sharenumber = value; }
        }
        /// <summary>
        /// Gets or sets the stock price.
        /// </summary>
        /// <value>
        /// The stock price.
        /// </value>
        public double StockPrice
        {
            get { return this.stockprice; }
            set { this.stockprice = value; }
        }
    }
}
