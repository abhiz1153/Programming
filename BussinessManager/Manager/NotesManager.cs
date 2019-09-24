using BussinessManager.Interface;
using Common.Models.NotesModels;
using FundooRepository.Interface;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManager.Manager
{
    public class NotesManager : INotes
    {
        private readonly INotesRepository notesRepository;
        public NotesManager(INotesRepository notesRepository)
        {
            this.notesRepository = notesRepository;
        }
        public async Task<string> AddAsync(NotesModel notesModel)
        {
            try
            {
                await this.notesRepository.AddNotes(notesModel);
                return "NOTES ADDED SUCCESSFULLY";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<string> DeleteAsync(int id)
        {
            try
            {
                await this.notesRepository.DeleteNotes(id);
                return "NOTES DELETED SUCESSFULLY";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<string> UpdateAsync(NotesModel notesModel)
        {
            try
            {
                await this.notesRepository.UpdateNotes(notesModel);
                return "NOTES DETALS UPDATES SUCESSFULLY";
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<NotesModel> GetAllListAsync()
        {
            try
            {
                var list = new List<NotesModel>();
                var result = this.notesRepository.GetList();
                foreach(var item in result)
                {
                    list.Add(item);
                }
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<NotesModel> GetNotesAsync(int id)
        {
            try
            {
                var list = new List<NotesModel>();
                var result = this.notesRepository.GetNotes(id);
                foreach (var item in result)
                {
                    list.Add(item);
                }
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<string> IsArchiveAsync(int id)
        {
            try
            {
                await this.notesRepository.IsArchive(id);
                return "ARCHIVE SUCCESS";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<string> UnArchiveAsync(int id)
        {
            try
            {
                await this.notesRepository.UnArchive(id);
                return "UNARCHIVE SUCCESS";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<string> IsTrashAsync(int id)
        {
            try
            {
                await this.notesRepository.IsTrash(id);
                return "UPDATES SUCESSFULLY";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<string> RestoreAsync(int id)
        {
            try
            {
                await this.notesRepository.Restore(id);
                return "UPDATES SUCESSFULLY";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<string> IsPinAsync(int id)
        {
            try
            {
                await this.notesRepository.IsPin(id);
                return "UPDATES SUCESSFULLY";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<string> UnPinAsync(int id)
        {
            try
            {
                await this.notesRepository.UnPin(id);
                return "UPDATES SUCESSFULLY";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public string UploadImages(int id,IFormFile image)
        {
            try
            {
                this.notesRepository.UploadImages(id, image);
                return "IMAGES UPLOADED SUCESSFULLY";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }         
        }
    }
}
