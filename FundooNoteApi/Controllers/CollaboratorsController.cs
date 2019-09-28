using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessManager.Interface;
using Common.Models.CollaboratorsModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FundooNoteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollaboratorsController : ControllerBase
    {
        private readonly ICollaborator collaborators;
        public CollaboratorsController(ICollaborator collaborator)
        {
            this.collaborators = collaborator;
        }
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
        [HttpDelete]
        [Route("remove")]
        public async Task<IActionResult> Delete(CollaboratorsModel collaboratorsModel)
        {
            try
            {
                var result = await this.collaborators.RemoveCollaboratorAsync(collaboratorsModel);
                return this.Ok(new { result});
            }
            catch(Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
    }
}