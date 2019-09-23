using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessManager.Interface;
using Common.Models.NotesModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FundooNoteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        public readonly INotes notes;
        public NotesController(INotes notes)
        {
            this.notes = notes;
        }

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
        [HttpGet]
        [Route("view")]
        public List<NotesModel> List()
        {
            return this.notes.GetAllListAsync();
        }
        [HttpGet]
        [Route("note")]
        public  List<NotesModel> List(int id)
        {
            return this.notes.GetNotesAsync(id);
        }
        [HttpGet]
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
    }
}
