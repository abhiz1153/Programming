// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryTypes.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPs.InventoryManagementProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class For Inventory types 
    /// </summary>
    public class InventoryTypes
    {
        /// <summary>
        /// The rice list
        /// </summary>
        private List<RiceClass> riceList = new List<RiceClass>();

        /// <summary>
        /// The wheat list
        /// </summary>
        private List<WheatClass> wheatList = new List<WheatClass>();

        /// <summary>
        /// The pulses list
        /// </summary>
        private List<PulsesClass> pulsesList = new List<PulsesClass>();

        /// <summary>
        /// Gets or sets the rice list.
        /// </summary>
        /// <value>
        /// The rice list.
        /// </value>
        public List<RiceClass> RiceList
        {
            get
            {
                return this.riceList;
            }
            set
            {
                this.riceList = value;
            }
        }

        /// <summary>
        /// Gets or sets the wheat list.
        /// </summary>
        /// <value>
        /// The wheat list.
        /// </value>
        public List<WheatClass> WheatList
        {
            get
            {
                return this.wheatList;
            }
            set
            {
                this.wheatList = value;
            }
        }

        /// <summary>
        /// Gets or sets the pulses list.
        /// </summary>
        /// <value>
        /// The pulses list.
        /// </value>
        public List<PulsesClass> PulsesList
        {
            get
            {
                return this.pulsesList;
            }
            set
            {
                this.pulsesList = value;
            }
        }
    }
}
