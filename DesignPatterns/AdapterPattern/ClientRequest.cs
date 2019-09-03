// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ClientRequest.cs" company="Bridgelabz">
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
    /// Class For ThirdPartyBillingSystem
    /// </summary>
    class ClientRequest
    {
        /// <summary>
        /// The employee source
        /// </summary>
        private ITarget employeeSource;
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRequest"/> class.
        /// </summary>
        /// <param name="employeeSource">The employee source.</param>
        public ClientRequest(ITarget employeeSource)
        {
            this.employeeSource = employeeSource;
        }
        /// <summary>
        /// Shows the employee list.
        /// </summary>
        public void ShowEmployeeList()
        {
            List<string> employee = employeeSource.GetEmployeeList();
            //To DO: Implement you business logic

            Console.WriteLine("######### EMPLOYEE LIST ##########");
            Console.WriteLine("EMPLOYEE_ID\tEMPLOYEE_NAME\tDESIGNATION");
            Console.WriteLine("------------------------------------------");
            foreach (var item in employee)
            {
                Console.Write(item);
            }

        }
    }

}

