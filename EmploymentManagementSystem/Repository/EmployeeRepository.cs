// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmploymentManagementSystem.Repository
{
    using EmploymentManagementSystem.Model;
    using Microsoft.Extensions.Configuration;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Threading.Tasks;
    /// <summary>
    /// Public Class for EmployeeRepository
    /// </summary>
    /// <seealso cref="EmploymentManagementSystem.Model.IEmployeeManagement" />
    public class EmployeeRepository : IEmployeeManagement
    {
        /// <summary>
        /// The connect
        /// </summary>
        private SqlConnection connect = null;
        /// <summary>
        /// The configuration
        /// </summary>
        private readonly IConfiguration _configuration=null;
        /// <summary>
        /// The connectstr
        /// </summary>
        string connectstr = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeRepository"/> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        public EmployeeRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeRepository"/> class.
        /// </summary>
        public EmployeeRepository()
        {
        }
        /// <summary>
        /// Connections this instance.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void Connection()
        {
            try
            {
                connectstr = _configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
                connect = new SqlConnection(connectstr);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="designation">The designation.</param>
        /// <param name="city">The city.</param>
        /// <param name="salary">The salary.</param>
        /// <returns></returns>
        public bool AddEmployee(string name,string designation, string city, int salary)
        {
            Connection();
            SqlCommand command = new SqlCommand("AddEmployee", connect);
            Employee employee = new Employee();
            //employee.ID = id;
            employee.Name = name;
            employee.Designation = designation;
            employee.City = city;
            employee.Salary = salary;
            command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.AddWithValue("@ID", employee.ID);
            command.Parameters.AddWithValue("@Name", employee.Name);
            command.Parameters.AddWithValue("@Designation", employee.Designation);
            command.Parameters.AddWithValue("@City", employee.City);
            command.Parameters.AddWithValue("@Salary", employee.Salary);
            connect.Open();
            int i = command.ExecuteNonQuery();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="designation">The designation.</param>
        /// <param name="city">The city.</param>
        /// <param name="salary">The salary.</param>
        /// <returns></returns>
        public bool UpdateEmployee(int id, string name,string designation, string city, int salary)
        {
            Connection();
            SqlCommand command = new SqlCommand("UpdateEmployee", connect);
            Employee employee = new Employee();
            employee.ID = id;
            employee.Name = name;
            employee.Designation = designation;
            employee.City = city;
            employee.Salary = salary;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ID", employee.ID);
            command.Parameters.AddWithValue("@Name", employee.Name);
            command.Parameters.AddWithValue("@Designation", employee.Designation);
            command.Parameters.AddWithValue("@City", employee.City);
            command.Parameters.AddWithValue("@Salary", employee.Salary);
            connect.Open();
            int i = command.ExecuteNonQuery();
            connect.Close();
            
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public bool DeleteEmployee(int id)
        {
            Connection();
            SqlCommand command = new SqlCommand("DeleteEmployee", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);
            connect.Open();
            int i = command.ExecuteNonQuery();
            connect.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Gets the employees.
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetEmployees()
        {
            Connection();
            List<Employee> employees = new List<Employee>();
            SqlCommand command = new SqlCommand("ViewEmployee", connect);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            connect.Open();
            adapter.Fill(dataTable);
            connect.Close();
            employees = (from DataRow data in dataTable.Rows
                         select new Employee()
                         {
                             ID = Convert.ToInt32(data["id"]),
                             Name = Convert.ToString(data["name"]),
                             Designation = Convert.ToString(data["designation"]),
                             City = Convert.ToString(data["city"]),
                             Salary = Convert.ToInt32(data["salary"])
                         }
                         ).ToList();
            return employees;
        }
        /// <summary>
        /// Logins the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool Login(string username,string password)
        {
            Connection();
            SqlCommand command = new SqlCommand("Login", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Name", username);
            command.Parameters.AddWithValue("@Designation", password);
            connect.Open();
            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataSet);
            connect.Close();
            bool loginSuccessful = ((dataSet.Tables.Count>0)&& (dataSet.Tables[0].Rows.Count>0));
            if(loginSuccessful && username != "" && password != " ")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}