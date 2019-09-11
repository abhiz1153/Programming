// --------------------------------------------------------------------------------------------------------------------
// <copyright file=HomeController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmploymentManagementSystem.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EmploymentManagementSystem.Model;
    using EmploymentManagementSystem.Repository;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    //[Route("api/[controller]")]
    //[ApiController]
    /// <summary>
    /// Public class for HomeControlle
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    public class HomeController : ControllerBase
    {
        /// <summary>
        /// The employee repository
        /// </summary>
        EmployeeRepository employeeRepository = new EmployeeRepository();    
        /// <summary>
        /// The employee manager/
        /// </summary>
        private IEmployeeManager employeeManager = null;
        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="_employeeManager">The employee manager.</param>
        public HomeController(IEmployeeManager _employeeManager)
        {
            employeeManager = _employeeManager;
        }
        /// <summary>
        /// Lists the of employees.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("view")]
        public IActionResult ListOfEmployees()
        {
            try
            {
                // Employee employee = new Employee();
                //  List<Employee> list = employeeManager.Get();
                return Ok(employeeManager.Get());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Adds the employees.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        public IActionResult AddEmployees(Employee employee)
        {
            try
            {

                var result = employeeManager.Add(employee.Name, employee.Designation, employee.City, employee.Salary);
                return Ok(new { result });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Updates the employees.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("update")]
        public ActionResult UpdateEmployees(Employee employee)
        {
            try
            {

                var result = employeeManager.Update(employee.ID, employee.Name, employee.Designation, employee.City, employee.Salary);
                return Ok(new { result });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Deletes the employees.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("delete")]
        public ActionResult DeleteEmployees(Employee employee)
        {
            try
            {
                var result = employeeManager.Delete(employee.ID);
                return Ok(new { result });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Logins the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("login")]
        public ActionResult Login(string username, string password)
        {
            try
            { 
                var result = employeeManager.Login(username, password);
                  return Ok(new { result });

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}