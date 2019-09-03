// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MakeOrder.cs" company="Bridgelabz">
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
    /// Make Order is class for making our order with our choice
    /// </summary>
    class MakeOrder
    {
        /// <summary>
        /// Starts the order.
        /// </summary>
        public void StartOrder()
        {
            try
            {
                char condition;
                do
                {
                    int choice;
                    Console.WriteLine("*****WELCOME*****");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("1. For Oder Pizza");
                    Console.WriteLine("2. For Order Sandwitch");
                    Console.WriteLine("");
                    Console.WriteLine("CHOOSE WHAT YOU WANT TO HAVE");
                    Console.WriteLine("");
                    choice = Convert.ToInt32(Console.ReadLine());
                    FacadePattern.FacadeRestaurant FacadeForclient = new FacadeRestaurant();
                    switch (choice)
                    {
                        case 1:
                            {
                                Console.WriteLine("-----------Pizza----------");
                                char condition1;
                                int choice1;
                                do
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("1. For Veg Pizza");
                                    Console.WriteLine("2. For Non-Veg Pizza");
                                    Console.WriteLine("");
                                    Console.WriteLine("CHOOSE WHAT YOU WANT TO HAVE");
                                    Console.WriteLine("");
                                    choice1 = Convert.ToInt32(Console.ReadLine());
                                    switch (choice1)
                                    {
                                        case 1:
                                            Console.WriteLine("-----------Customer Order For Veg Pizza----------");

                                            FacadeForclient.OrderVegPizza();

                                            break;
                                        case 2:
                                            Console.WriteLine("-----------Costomer Order For NonVeg Pizza------- ");
                                            FacadeForclient.OrderNonVegPizza();
                                            break;
                                    }
                                    Console.WriteLine("Enter 'y' or 'Y' if you want to continue...");
                                    condition1 = Convert.ToChar(Console.ReadLine());
                                }
                                while (condition1 == 'y' || condition1 == 'Y');
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("----------Sandwitch----------");
                                char condition2;
                                int choice2;
                                do
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("1. Garlic Sandwitch");
                                    Console.WriteLine("2. Chees Garlic Sandwitch");
                                    Console.WriteLine("");
                                    Console.WriteLine("CHOOSE WHAT YOU WANT TO HAVE");
                                    Console.WriteLine("");
                                   choice2 = Convert.ToInt32(Console.ReadLine());
                                    switch (choice2)
                                    {
                                        case 1:
                                            Console.WriteLine("-----------Customer Order For Garlic Sandwitch----------");

                                            FacadeForclient.OrderGarlicSadnwitch();
                                            break;
                                        case 2:
                                            Console.WriteLine("-----------Costomer Order For Chees Garlic Sandwitch------- ");
                                            FacadeForclient.OrderCheesGarlicSandwitch();
                                            break;
                                    }
                                    Console.WriteLine("Enter 'y' or 'Y' if you want to continue...");
                                    condition2 = Convert.ToChar(Console.ReadLine());
                                }
                                while (condition2 == 'y' || condition2 == 'Y');
                            }
                            break;
                    }
                    Console.WriteLine("Enter 'y' or 'Y' if you want to continue...");
                    condition = Convert.ToChar(Console.ReadLine());
                }
                while (condition == 'y' || condition == 'Y');
                Console.WriteLine("Thank You For Placing Order With Ous ...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}