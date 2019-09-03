// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ProxyAddition.cs" company="Bridgelabz">
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
    /// Class for ProxyAddition
    /// </summary>
    /// <seealso cref="DesignPatterns.ProxyPattern.IResult" />
    class ProxyAddition : IResult 
    {
        IResult result;
        /// <summary>
        /// Get Result as Double value
        /// </summary>
        /// <returns></returns>
        public double GetResult()
        {
            Console.WriteLine("Enter two Number for Addition");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            result = new Addition(a, b);
            return result.GetResult();           
        }
        /// <summary>
        /// Detailses this instance.
        /// </summary>
        public void Details()
        {
            Console.WriteLine("ADDITION OPERATION \n");
        }
        
    }
}