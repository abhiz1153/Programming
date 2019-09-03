// --------------------------------------------------------------------------------------------------------------------
// <copyright file=HRSystem.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.AdapterPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Class for HRSystem 
    /// </summary>
    public class HRSystem
    {
        /// <summary>
        /// Gets the employees.
        /// </summary>
        /// <returns>employees</returns>
        public string[][] GetEmployees()
        {
            Console.WriteLine("Enter how many Employee Details You want to ADD");
            int n = Convert.ToInt32(Console.ReadLine());

            string[][] employees = new string[n][];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter " + ++i + " Employee Name");
                string name = Console.ReadLine();
                i--;
                Console.WriteLine("Enter " + name + " Employee ID");
                string id = Console.ReadLine();
                Console.WriteLine("Enter " + name + " Designation");
                string role = Console.ReadLine();

                employees[i] = new string[] { id, name, role };
            }
            return employees;
        }
    }

}
