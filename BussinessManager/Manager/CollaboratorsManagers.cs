// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CollaboratorsManagers.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
using BussinessManager.Interface;
using Common.Models.CollaboratorsModels;
using FundooRepository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManager.Manager
{
    /// <summary>
    /// This class is for configure with Collaborators Repository
    /// </summary>
    /// <seealso cref="BussinessManager.Interface.ICollaborator" />
    public class CollaboratorsManagers : ICollaborator
    {
        /// <summary>
        /// The collaborator repository
        /// </summary>
        private readonly ICollaboratorsRepository collaboratorRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CollaboratorsManagers"/> class.
        /// </summary>
        /// <param name="collaboratorsRepository">The collaborators repository.</param>
        public CollaboratorsManagers(ICollaboratorsRepository collaboratorsRepository)
        {
            this.collaboratorRepository = collaboratorsRepository;
        }

        /// <summary>
        /// Adds the collaborator asynchronous.
        /// </summary>
        /// <param name="collaboratorsModel">The collaborators model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Removes the collaborator asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> RemoveCollaboratorAsync(int id)
        {
            try
            {
                await this.collaboratorRepository.DeleteCollaboratorsNotes(id);
                return "COLLABORATION DELETED SUCCESSFULLY";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Collaborators the list.
        /// </summary>
        /// <param name="notesId">The notes identifier.</param>
        /// <returns></returns>
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
