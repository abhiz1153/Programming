// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IEmployeeManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmploymentManagementSystem.Controllers
{
    using System;
    using EmploymentManagementSystem.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    /// <summary>
    /// Public Interface for IEmployeeManager 
    /// </summary>
    public interface IEmployeeManager
    {
        /// <summary>
        /// Adds the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="designation">The designation.</param>
        /// <param name="city">The city.</param>
        /// <param name="salary">The salary.</param>
        /// <returns></returns>
        string Add(string name,string designation, string city, int salary);
        /// <summary>
        /// Updates the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="designation">The designation.</param>
        /// <param name="city">The city.</param>
        /// <param name="salaryy">The salaryy.</param>
        /// <returns></returns>
        string Update(int id, string name, string designation, string city, int salaryy);
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        string Delete(int id);
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Employee> Get();
        /// <summary>
        /// Logins the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="designation">The designation.</param>
        /// <returns></returns>
        string Login(string name, string designation);
    }
}
