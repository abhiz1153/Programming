// ---------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=ILabel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// ---------------------------------------------------------------------------------------------------------------------------------------------------------
namespace BussinessManager.Interface
{
    using Common.Models.LabelModels;
    using System.Collections.Generic;
    /// <summary>
    /// public interface for Label
    /// </summary>
    public interface ILabel
    {
        /// <summary>
        /// Adds the specified label model.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        string Add(LabelModel labelModel);

        /// <summary>
        /// Updates the specified label model.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        string Update(LabelModel labelModel);

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        string Delete(int id);

        /// <summary>
        /// Gets all list.
        /// </summary>
        List<LabelModel> GetAllList();

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <param name="email">The email.</param>
        List<LabelModel> GetLabel(string email);
    }
}
