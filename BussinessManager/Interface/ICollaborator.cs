using Common.Models.CollaboratorsModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManager.Interface
{
    public interface ICollaborator
    {
        Task<string> AddCollaboratorAsync(CollaboratorsModel collaboratorsModel);
        Task<string> RemoveCollaboratorAsync(CollaboratorsModel collaboratorsModel);
    }
}
