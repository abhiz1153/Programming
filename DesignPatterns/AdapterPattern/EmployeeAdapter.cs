// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeAdapter.cs" company="Bridgelabz">
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
    /// Class for EmployeeAdapter
    /// </summary>
    /// <seealso cref="DesignPatterns.AdapterPattern.HRSystem" />
    /// <seealso cref="DesignPatterns.AdapterPattern.ITarget" />
    public class EmployeeAdapter : HRSystem, ITarget
    {
        /// <summary>
        /// Gets the employee list.
        /// </summary>
        /// <returns></returns>
        public List<string> GetEmployeeList()
        {
            List<string> employeeList = new List<string>();
            string[][] employees = GetEmployees();
            foreach (string[] employee in employees)
            {
                employeeList.Add(employee[0]);
                employeeList.Add("\t\t");
                employeeList.Add(employee[1]);
                employeeList.Add("\t\t");
                employeeList.Add(employee[2]);
                employeeList.Add("\n");
            }

            return employeeList;
        }
    }

}