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
        Task DeleteCollaboratorsNotes(CollaboratorsModel collaboratorsModels);
    }
}
