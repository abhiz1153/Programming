// ---------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=ICollaborator.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// ---------------------------------------------------------------------------------------------------------------------------------------------------------
namespace BussinessManager.Interface
{
    using Common.Models.CollaboratorsModels;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    /// <summary>
    /// public interface for Collaborator
    /// </summary>
    public interface ICollaborator
    {
        /// <summary>
        /// Adds the collaborator asynchronous.
        /// </summary>
        /// <param name="collaboratorsModel">The collaborators model.</param>
        Task<string> AddCollaboratorAsync(CollaboratorsModel collaboratorsModel);

        /// <summary>
        /// Removes the collaborator asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        Task<string> RemoveCollaboratorAsync(int id);

        /// <summary>
        /// Collaborators the list.
        /// </summary>
        /// <param name="notesId">The notes identifier.</param>
        List<CollaboratorsModel> CollaboratorList(int notesId);
    }
}
