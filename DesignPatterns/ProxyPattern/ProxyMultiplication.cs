// <copyright file=ProxyMultiplication.cs" company="Bridgelabz">
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
    /// Class for ProxyMultiplication
    /// </summary>
    class ProxyMultiplication 
    {
        IResult result;
        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <returns></returns>
        public double GetResult()
        {
            Console.WriteLine("Enter two Number for Multiplication");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            result = new Multiplication(a, b);
            return result.GetResult();
        }
        /// <summary>
        /// Detailses this instance.
        /// </summary>
        public void Details()
        {
            Console.WriteLine("MULTIPLICATION OPERATION \n");
        }
    }
}
