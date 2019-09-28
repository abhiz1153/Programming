using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models.CollaboratorsModels;
using FundooRepository.DBContext;
using FundooRepository.Interface;

namespace FundooRepository.Repository
{
    public class CollaboratorsRepository : ICollaboratorsRepository
    {
        private readonly UserContext userContext;
        public CollaboratorsRepository(UserContext userContext)
        {
            this.userContext= userContext;
        }

        public Task AddCollaboratorsToNotes(CollaboratorsModel collaboratorsModel)
        {
            try
            {
                bool result = this.userContext.Notes.Any(r => r.Email == collaboratorsModel.SenderEmail && r.Id == collaboratorsModel.NoteId);
                if(result)
                {
                    var user = this.userContext.Register.Where(u => u.Email == collaboratorsModel.ReciverEmail).SingleOrDefault();
                    {
                        var collaborators = new CollaboratorsModel()
                        {
                            NoteId = collaboratorsModel.NoteId,
                            SenderEmail = collaboratorsModel.SenderEmail,
                            ReciverEmail = collaboratorsModel.ReciverEmail
                        };
                    }
                    userContext.Collaborators.Add(collaboratorsModel);
                }
                return Task.Run(() => userContext.SaveChanges());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public Task DeleteCollaboratorsNotes(CollaboratorsModel collaboratorsModels)
        {
            try
            {
                var result = this.userContext.Collaborators.Where(r => r.NoteId == collaboratorsModels.NoteId).Single();
                this.userContext.Collaborators.Remove(result);
                return Task.Run(() => userContext.SaveChanges());
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
