// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Adapter.cs" company="Bridgelabz">
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
    /// Class For Adapter
    /// </summary>
    class Adapter
    {
        /// <summary>
        /// Adapters this instance.
        /// </summary>
        public void adapter()
        {
            ITarget Itarget = new EmployeeAdapter();
           ClientRequest client = new ClientRequest(Itarget);
            client.ShowEmployeeList();
            Console.ReadKey();
        }
    }
}
