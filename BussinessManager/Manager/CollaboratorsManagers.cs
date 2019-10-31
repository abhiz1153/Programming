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
        public async Task<string> RemoveCollaboratorAsync(int id)
        {
            try
            {
                await this.collaboratorRepository.DeleteCollaboratorsNotes(id);
                return "COLLABORATION DELETED SUCCESSFULLY";
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<CollaboratorsModel> CollaboratorList(int notesId)
        {
            
                var list = new List<CollaboratorsModel>();
                var result = this.collaboratorRepository.GetCollaborator(notesId);
                if (result != null)
                {
                    foreach (var item in result)
                    {
                        list.Add(item);
                    }
                    return list;
                }
                else
                {
                    return null;
                }
            
            
        }       
    }
}
