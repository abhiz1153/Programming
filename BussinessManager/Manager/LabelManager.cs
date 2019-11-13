// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
using BussinessManager.Interface;
using Common.Models.LabelModels;
using FundooRepository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManager.Manager
{
    /// <summary>
    /// This class is to get Label repository
    /// </summary>
    /// <seealso cref="BussinessManager.Interface.ILabel" />
    public class LabelManager : ILabel
    {
        /// <summary>
        /// The label repository
        /// </summary>
        public readonly ILabelRepository labelRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelManager"/> class.
        /// </summary>
        /// <param name="labelRepository">The label repository.</param>
        public LabelManager(ILabelRepository labelRepository)
        {
            this.labelRepository = labelRepository;
        }

        /// <summary>
        /// Adds the specified label model.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string Add(LabelModel labelModel)
        {
            try
            {
                this.labelRepository.AddLabel(labelModel);
                return "LABEL ADDED SUCCESSFULLY";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Updates the specified label model.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string Update(LabelModel labelModel)
        {
            try
            {
                this.labelRepository.UpdateLabel(labelModel);
                return "LABEL UPDATED SUCCESSFULLY";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string Delete(int id)
        {
            try
            {
                this.labelRepository.DeleteLabel(id);
                return "LABEL DELETED SUCESSFULLY";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Gets all list.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<LabelModel> GetAllList()
        {
            try
            {
                var list = new List<LabelModel>();
                var result = this.labelRepository.GetList();
                foreach (var item in result)
                {
                    list.Add(item);
                }
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<LabelModel> GetLabel(string email)
        {
            try
            {
                var list = new List<LabelModel>();
                var result = this.labelRepository.GetLabel(email);
               if(result != null)
                { 
                foreach (var item in result)
                {
                    list.Add(item);
                }
                return list;
                }
               return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}