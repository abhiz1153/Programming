using BussinessManager.Interface;
using Common.Models.CollaboratorsModels;
using FundooRepository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManager.Manager
{
    public class CollaboratorsManagers : ICollaborator
    {
        private readonly ICollaboratorsRepository collaboratorRepository;
        public CollaboratorsManagers(ICollaboratorsRepository collaboratorsRepository)
        {
            this.collaboratorRepository = collaboratorsRepository;
        }
        public async Task<string> AddCollaboratorAsync(CollaboratorsModel collaboratorsModel)
        {
            try
            {
                await this.collaboratorRepository.AddCollaboratorsToNotes(collaboratorsModel);
                return "COLLABORATION ADDED SUCCESSFULLY";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<string> RemoveCollaboratorAsync(CollaboratorsModel collaboratorsModel)
        {
            try
            {
                await this.collaboratorRepository.DeleteCollaboratorsNotes(collaboratorsModel);
                return "COLLABORATION DELETED SUCCESSFULLY";
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
