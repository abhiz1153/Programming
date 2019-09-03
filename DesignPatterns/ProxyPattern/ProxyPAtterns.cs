// <copyright file=ProxyPatterns.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.ProxyPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Class for ProxyPatterns
    /// </summary>
    class ProxyPatterns
    {
        /// <summary>
        /// Patterns this instance.
        /// </summary>
        public void Pattern()
        {
            try
            {
                char choose;
                int choice;
                do
                {
                    Console.WriteLine("*****PROXY DESIGN PATTERN*****");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Multiplication");
                    Console.WriteLine("3. Substraction");
                    Console.WriteLine("4. Division");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("CHOOSE WHAT YOU WANT TO HAVE");
                    Console.WriteLine("");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            ProxyAddition proxyAddition = new ProxyAddition();
                            proxyAddition.Details();
                            double additionResult = proxyAddition.GetResult();
                            Console.WriteLine("The Addition of two Number = " + additionResult);
                            return;
                        case 2:
                            ProxyMultiplication proxyMultiplication = new ProxyMultiplication();
                            proxyMultiplication.Details();
                            double multiplicationResult = proxyMultiplication.GetResult();
                            Console.WriteLine("The Multiplication of two Number = " + multiplicationResult);
                            break;
                        case 3:
                            ProxySubstraction proxySubstraction = new ProxySubstraction();
                            proxySubstraction.Details();
                            double substractionResult = proxySubstraction.GetResult();
                            Console.WriteLine("The Substraction of two Number = " + proxySubstraction);
                            break;
                        case 4:
                            ProxyDivision proxyDivision = new ProxyDivision();
                            proxyDivision.Details();
                            double divisionResult = proxyDivision.GetResult();
                            Console.WriteLine("The Division of two Number = " + divisionResult);
                            break;
                    }
                    Console.WriteLine("Do you want to Continue then Press Y");
                    choose = Convert.ToChar(Console.ReadLine());
                }
                while (choose == 'y');
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
