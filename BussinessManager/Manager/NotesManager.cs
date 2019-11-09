using BussinessManager.Interface;
using Common.Models.CollaboratorModel;
using Common.Models.NotesLabelsModels;
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
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<NotesModel> GetAllListAsync()
        {

            var list = new List<NotesModel>();
            var result = this.notesRepository.GetList();
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
        public List<NotesModel> GetNotesAsync(string Email)
        {

            var list = new List<NotesModel>();
            var result = this.notesRepository.GetNotes(Email);
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
        public List<NotesModel> GetReminderAsync(string Email)
        {
            var list = new List<NotesModel>();
            var result = this.notesRepository.GetReminder(Email);
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

            await this.notesRepository.UnArchive(id);
            return "UNARCHIVE SUCCESS";
        }
        public List<NotesModel> GetArchiveNote(string Email)
        {

            {
                var list = new List<NotesModel>();
                var result = this.notesRepository.ArchiveNote(Email);
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
        public List<NotesModel> GetArchiveList()
        {
            var list = new List<NotesModel>();
            var result = this.notesRepository.ArchiveList();
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
        public List<NotesModel> TrashList(string Email)
        {
            var list = new List<NotesModel>();
            var result = this.notesRepository.GetTrashList(Email);
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
        public async Task<string> RestoreAsync(int id)
        {

            await this.notesRepository.Restore(id);
            return "UPDATES SUCESSFULLY";

        }
        public async Task<string> DragAndDropAsync(string Email, int Id, int IndexValue)
        {
            await this.notesRepository.DragAndDrop(Email, Id, IndexValue);
            return "Index Added Successfully";
        }
        public async Task<string> RestoreAllNote(string Email)
        {
            await this.notesRepository.RestoreAll(Email);
            return "Restore Successfully";
        }
        public async Task<string> RemoveAllTrash(string Email)
        {

            await this.notesRepository.RemoveTrash(Email);
            return "TRASH REMOVED";

        }

        public async Task<string> IsPinAsync(int id)
        {

            await this.notesRepository.IsPin(id);
            return "UPDATES SUCESSFULLY";

        }
        public async Task<string> UnPinAsync(int id)
        {

            await this.notesRepository.UnPin(id);
            return "UPDATES SUCESSFULLY";

        }
        public string UploadImages(int id, IFormFile image)
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
        public string RemainderValue(int id, string reminder)
        {
            try
            {
                this.notesRepository.Remainder(id, reminder);
                return "Reminder Updated Succefully";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<string> SetColor(int id, string color)
        {
            try
            {
                await this.notesRepository.Color(id, color);
                return "UPDATES SUCESSFULLY";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<NotesModel> SearchNotes(string title)
        {

            var list = new List<NotesModel>();
            var result = this.notesRepository.Search(title);
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
     
        public async Task<string> AddNotesLabelAsync(NoteLabelModel model)
        {
            try
            {
                await this.notesRepository.AddNotesLabel(model);
                return "LABELS ADDED TO NOTES";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<NoteLabelModel> GetNotesLabel(int noteId)
        {
            var list = new List<NoteLabelModel>();
            var result = this.notesRepository.GetNotesLabel(noteId);
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

        /// <summary>
        /// Deletes the notes label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public string DeleteNotesLabel(int id)
        {
            return this.notesRepository.DeleteNotesLabel(id);
        }
        public List<NoteLabelModel> GetAllLabelListAsync()
        {

            var list = new List<NoteLabelModel>();
            var result = this.notesRepository.GetLabelList();
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
