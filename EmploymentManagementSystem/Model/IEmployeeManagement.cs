// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IEmployeeManagement.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmploymentManagementSystem.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    /// <summary>
    /// Public Interface for IEmployeeManagement
    /// </summary>
    public interface IEmployeeManagement
    {
        /// <summary>
        /// Gets the employees.
        /// </summary>
        /// <returns></returns>
        List<Employee> GetEmployees();
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="designation">The designation.</param>
        /// <param name="city">The city.</param>
        /// <param name="salary">The salary.</param>
        /// <returns></returns>
        bool AddEmployee(string name,string designation, string city, int salary);
        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="designation">The designation.</param>
        /// <param name="city">The city.</param>
        /// <param name="salary">The salary.</param>
        /// <returns></returns>
        bool UpdateEmployee(int id, string name, string designation, string city, int salary);
        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        bool DeleteEmployee(int id);
        /// <summary>
        /// Logins the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="designation">The designation.</param>
        /// <returns></returns>
        bool Login(string name, string designation);
      
    }
}
