// ----------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesController.cs" company="Bridgelabz">
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
    using Common.Models.CollaboratorModel;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    /// <summary>
    /// Public class Controller for NotesController
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        /// <summary>
        /// The notes
        /// </summary>
        public readonly INotes notes;
        /// <summary>
        /// Initializes a new instance of the <see cref="NotesController"/> class.
        /// </summary>
        /// <param name="notes">The notes.</param>
        public NotesController(INotes notes)
        {
            this.notes = notes;
        }
        /// <summary>
        /// Adds the specified notes model.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add(NotesModel notesModel)
        {
            try
            {

                var result = await this.notes.AddAsync(notesModel);
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
        [Route("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var result = await this.notes.DeleteAsync(id);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Updates the specified notes model.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> Update(NotesModel notesModel)
        {
            try
            {
                var result = await this.notes.UpdateAsync(notesModel);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Lists this instance.
        /// </summary>
        /// <returns></returns>
        [HttpGet, Authorize]
        [Route("view")]
        public List<NotesModel> List()
        {
            return this.notes.GetAllListAsync();
        }
        /// <summary>
        /// Lists the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("note")]
        public  List<NotesModel> List(string Email)
        {
            return this.notes.GetNotesAsync(Email);
        }
        /// <summary>
        /// Determines whether the specified identifier is trash.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("trash")]
        public async Task<IActionResult> IsTrash(int id)
        {
            try
            {
                var result = await this.notes.IsTrashAsync(id);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Alls the trash list.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("trashlist")]
        public List<NotesModel> AllTrashList(string Email)
        {
            return this.notes.TrashList(Email);
        }

        /// <summary>
        /// Restores the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("restore")]
        public async Task<IActionResult> Restore(int id)
        {
            try
            {
                var result = await this.notes.RestoreAsync(id);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Restores all.
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [Route("restoreall")]
        public async Task<IActionResult> RestoreAll(string Email)
        {
            try
            {
                var result = await this.notes.RestoreAllNote(Email);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Removes all.
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        [Route("removetrash")]
        public async Task<IActionResult> RemoveAll(string Email)
        {
            try
            {
                var result = await this.notes.RemoveAllTrash(Email);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
       
        /// <summary>
        /// Determines whether the specified identifier is archive.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("isarchive")]
        public async Task<IActionResult> IsArchive(int id)
        {
            try
            {
                var result = await this.notes.IsArchiveAsync(id);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Uns the archive.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("unarchive")]
        public async Task<IActionResult> UnArchive(int id)
        {
            try
            {
                var result = await this.notes.UnArchiveAsync(id);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        [HttpGet]
        [Route("archivenote")]
        public List<NotesModel> ArchiveNoteList(string Email)
        {
            return this.notes.GetArchiveNote(Email);
        }
        [HttpGet]
        [Route("archivelist")]
        public List<NotesModel> ArchiveListAll()
        {
            return this.notes.GetArchiveList();
        }
        /// <summary>
        /// Determines whether the specified identifier is pin.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("ispin")]
        public async Task<IActionResult> IsPin(int id)
        {
            try
            {
                var result = await this.notes.IsPinAsync(id);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Uns the pin.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("unpin")]
        public async Task<IActionResult> UnPin(int id)
        {
            try
            {
                var result = await this.notes.UnPinAsync(id);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Uploads the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="image">The image.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("upload")]
        public IActionResult Upload(int id, IFormFile image)
        {
            try
            {
                var result = this.notes.UploadImages(id, image);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        [HttpPut]
        [Route("reminder")]
        public IActionResult Remainder(int id,string reminder)
        {
            try
            {
                var result = this.notes.RemainderValue(id, reminder);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        [HttpPut]
        [Route("color")]
        public async Task<IActionResult> Color(int id,string color)
        {
            try
            {
                var result = await this.notes.SetColor(id,color);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        [HttpGet]
        [Route("search")]
        public List<NotesModel> Search(string title)
        {
            return this.notes.SearchNotes(title);
        }
        [HttpGet]
        [Route("getReminder")]
        public List<NotesModel> ReminderList(string Email)
        {
            return this.notes.GetReminderAsync(Email);
        }
    }
}


