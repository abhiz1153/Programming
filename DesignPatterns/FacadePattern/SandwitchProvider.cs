// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SandwitchProvider.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.FacadePattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class sandwitch provider provides sandwitch variety for customer
    /// </summary>
    /// <seealso cref="DesignPatterns.FacadeDesignPattern.ISandwitch" />
    class SandwitchProvider : ISandwitch
    {
        /// <summary>
        /// Gets the cheesy sandwitch.
        /// </summary>
        public void GetCheesySandwitch()
        {
            try
            {
                GetCheese();
                Console.WriteLine("Getting Cheesy Garlic Sandwitch.");
                Console.WriteLine("Your Order Placed Successfully...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Gets the garlic sandwitch.
        /// </summary>
        public void GetGarlicSandwitch()
        {
            Console.WriteLine("Getting Garlic Sandwitch.");
            Console.WriteLine("Your Order Placed Successfully...");
            Console.WriteLine("");
            Console.WriteLine("Thank You \n Please Visit Again");
        }

        /// <summary>
        /// Gets the cheese.
        /// </summary>
        private void GetCheese()
        {
            Console.WriteLine("Getting Sandwitch.");
            Console.WriteLine("Your Order Placed Successfully...");
            Console.WriteLine("");
            Console.WriteLine("Thank You \n Please Visit Again");
        }
    }
}
