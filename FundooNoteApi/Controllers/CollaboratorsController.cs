// ----------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=CollaboratorsController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// ----------------------------------------------------------------------------------------------------------------------------------------------------------
namespace FundooNoteApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using BussinessManager.Interface;
    using Common.Models.CollaboratorsModels;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Public class Controller for CollaboratorsController
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class CollaboratorsController : ControllerBase
    {
        /// <summary>
        /// The collaborators
        /// </summary>
        private readonly ICollaborator collaborators;

        /// <summary>
        /// Initializes a new instance of the <see cref="CollaboratorsController"/> class.
        /// </summary>
        /// <param name="collaborator">The collaborator.</param>
        public CollaboratorsController(ICollaborator collaborator)
        {
            this.collaborators = collaborator;
        }

        /// <summary>
        /// Adds the specified collaborators model.
        /// </summary>
        /// <param name="collaboratorsModel">The collaborators model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add(CollaboratorsModel collaboratorsModel)
        {
            try
            {
                var result = await this.collaborators.AddCollaboratorAsync(collaboratorsModel);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("remove")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var result = await this.collaborators.RemoveCollaboratorAsync(id);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Gets the collaborator.
        /// </summary>
        /// <param name="notesId">The notes identifier.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("list")]
        public List<CollaboratorsModel> GetCollaborator(int notesId)
        {
            var result = this.collaborators.CollaboratorList(notesId);
            return result;
        }
    }
}