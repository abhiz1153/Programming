// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PrototypePattern.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.PrototypeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Class for Prototype
    /// </summary>
    class Prototype
    {
        /// <summary>
        /// Prototypes the pattern.
        /// </summary>
        public void PrototypePattern()
        {

            try
            {
                char choice;
                int choose;
                do
                {
                    Console.WriteLine("*****ACCOUNT DISPLAY*****");
                    Console.WriteLine(" ");
                    Console.WriteLine("1. Sales Managers Employee");
                    Console.WriteLine("2. Operator Employee");
                    Console.WriteLine("");
                    Console.WriteLine("WHICH ACCOUNT YOU WANT TO VIEW");
                    Console.WriteLine("");
                    Console.WriteLine("Enter your Choice");
                    Console.WriteLine(" ");
                    choose = Convert.ToInt32(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:
                            Inputs inputs1 = new Inputs();
                            inputs1.Sales();
                            break;
                        case 2:
                            Inputs inputs2 = new Inputs();
                            inputs2.OperatorEmployee();
                            break;
                    }
                    Console.WriteLine("Do you want to Continue then Press Y");
                    choice = Convert.ToChar(Console.ReadLine());
                }
                while (choice == 'y');
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
