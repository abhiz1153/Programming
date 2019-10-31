using Common.Models.CollaboratorsModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Interface
{
    public interface ICollaboratorsRepository
    {
        Task AddCollaboratorsToNotes(CollaboratorsModel collaboratorsModel);

        /// <summary>
        /// Deletes the collaborators notes.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task DeleteCollaboratorsNotes(int id);
        List<CollaboratorsModel> GetCollaborator(int notesId);
    }
}
