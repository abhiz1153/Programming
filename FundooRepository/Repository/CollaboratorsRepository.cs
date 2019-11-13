// --------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=CollaboratorsRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------------------------------------
namespace FundooRepository.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Common.Models.CollaboratorsModels;
    using FundooRepository.DBContext;
    using FundooRepository.Interface;

    /// <summary>
    ///  Public Class for CollaboratorsRepository
    /// </summary>
    /// <seealso cref="FundooRepository.Interface.ICollaboratorsRepository" />
    public class CollaboratorsRepository : ICollaboratorsRepository
    {
        /// <summary>
        /// The user context
        /// </summary>
        private readonly UserContext userContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="CollaboratorsRepository"/> class.
        /// </summary>
        /// <param name="userContext">The user context.</param>
        public CollaboratorsRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }

        /// <summary>
        /// Adds the collaborators to notes.
        /// </summary>
        /// <param name="collaboratorsModel">The collaborators model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Task AddCollaboratorsToNotes(CollaboratorsModel collaboratorsModel)
        {
            try
            {
                bool result = this.userContext.Notes.Any(r => r.Email == collaboratorsModel.SenderEmail && r.Id == collaboratorsModel.NoteId);
                if (result)
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

        /// <summary>
        /// Deletes the collaborators notes.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Task DeleteCollaboratorsNotes(int id)
        {
            try
            {
                var result = this.userContext.Collaborators.Where(r => r.Id == id).Single();
                this.userContext.Collaborators.Remove(result);
                return Task.Run(() => userContext.SaveChanges());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Gets the collaborator.
        /// </summary>
        /// <param name="notesId">The notes identifier.</param>
        /// <returns></returns>
        public List<CollaboratorsModel> GetCollaborator(int notesId)
        {
            bool result = userContext.Collaborators.Any(r => r.NoteId == notesId);
            if (result)
            {
                return userContext.Collaborators.Where(r => r.NoteId == notesId).ToList();
            }
            return null;
        }
    }
}
