// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------

namespace EmploymentManagementSystem.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using EmploymentManagementSystem.Model;
    using Microsoft.AspNetCore.Mvc;
    /// <summary>
    /// Public class for EmployeeManager 
    /// </summary>
    /// <seealso cref="EmploymentManagementSystem.Controllers.IEmployeeManager" />
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeManager : IEmployeeManager
    {
        /// <summary>
        /// The employee repository
        /// </summary>
        private readonly IEmployeeManagement employeeRepository;
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeManager"/> class.
        /// </summary>
        public EmployeeManager()
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeManager"/> class.
        /// </summary>
        /// <param name="employeeManagement">The employee management.</param>
        public EmployeeManager(IEmployeeManagement employeeManagement)
        {
            employeeRepository = employeeManagement;
        }
        /// <summary>
        /// The employee
        /// </summary>
        Employee employee = new Employee();
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> Get()
        {
            return (employeeRepository.GetEmployees().AsEnumerable());
        }
        /// <summary>
        /// Adds the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="designation">The designation.</param>
        /// <param name="city">The city.</param>
        /// <param name="salary">The salary.</param>
        /// <returns></returns>
        public string Add(string name,string designation, string city, int salary)
        {
            //employee.ID = id;
            employee.Name = name;
            employee.Designation = designation;
            employee.City = city;
            employee.Salary = salary;
            employeeRepository.AddEmployee(employee.Name, employee.Designation, employee.City, employee.Salary);
            return "Added successfully";
        }
        /// <summary>
        /// Updates the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="designation">The designation.</param>
        /// <param name="city">The city.</param>
        /// <param name="salary">The salary.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string Update(int id, string name,string designation, string city, int salary)
        {
            employee.ID = id;
            employee.Name = name;
            employee.Designation = designation;
            employee.City = city;
            employee.Salary = salary;
            try
            {
               bool result= employeeRepository.UpdateEmployee(employee.ID, employee.Name, employee.Designation, employee.City, employee.Salary);
                if (result)
                {
                    return "updated successfully";
                }

                else
                    return "failed";
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
           
        }
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public string Delete(int id)
        {
            employee.ID = id;
            employeeRepository.DeleteEmployee(employee.ID);
            return "Deleted successfully";
        }
        /// <summary>
        /// Logins the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="designation">The designation.</param>
        /// <returns></returns>
        public string Login(string name,string designation)
        {
            //employee.Name = name;
            //employee.Designation = designation;
            bool result = employeeRepository.Login(name, designation);
            if (result)
            {
                return "Login Successfully";
            }

            else
                return "failed";
        }
    }      
}