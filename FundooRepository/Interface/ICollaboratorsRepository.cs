// --------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=ICollaboratorsRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------------------------------------
namespace FundooRepository.Interface
{
    using Common.Models.CollaboratorsModels;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    ///  Public interface for ICollaboratorsRepository 
    /// </summary>
    public interface ICollaboratorsRepository
    {
        /// <summary>
        /// Adds the collaborators to notes.
        /// </summary>
        /// <param name="collaboratorsModel">The collaborators model.</param>
        /// <returns></returns>
        Task AddCollaboratorsToNotes(CollaboratorsModel collaboratorsModel);

        /// <summary>
        /// Deletes the collaborators notes.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task DeleteCollaboratorsNotes(int id);

        /// <summary>
        /// Gets the collaborator.
        /// </summary>
        /// <param name="notesId">The notes identifier.</param>
        /// <returns></returns>
        List<CollaboratorsModel> GetCollaborator(int notesId);
    }
}
