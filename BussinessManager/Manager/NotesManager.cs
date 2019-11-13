// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace BussinessManager.Manager
{
    using BussinessManager.Interface;
    using Common.Models.CollaboratorModel;
    using Common.Models.NotesLabelsModels;
    using FundooRepository.Interface;
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// NotesManager class is for Get notes repository
    /// </summary>
    /// <seealso cref="BussinessManager.Interface.INotes" />
    public class NotesManager : INotes
    {
        /// <summary>
        /// The notes repository
        /// </summary>
        private readonly INotesRepository notesRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotesManager"/> class.
        /// </summary>
        /// <param name="notesRepository">The notes repository.</param>
        public NotesManager(INotesRepository notesRepository)
        {
            this.notesRepository = notesRepository;
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Deletes the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Updates the asynchronous.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Gets all list asynchronous.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the notes asynchronous.
        /// </summary>
        /// <param name="Email"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the reminder asynchronous.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Determines whether [is archive asynchronous] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Uns the archive asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<string> UnArchiveAsync(int id)
        {
            await this.notesRepository.UnArchive(id);
            return "UNARCHIVE SUCCESS";
        }

        /// <summary>
        /// Gets the archive note.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the archive list.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Determines whether [is trash asynchronous] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Trashes the list.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Restores the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<string> RestoreAsync(int id)
        { 
            await this.notesRepository.Restore(id);
            return "UPDATES SUCESSFULLY";
        }

        /// <summary>
        /// Drags the and drop asynchronous.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <param name="Id">The identifier.</param>
        /// <param name="IndexValue">The index value.</param>
        /// <returns></returns>
        public async Task<string> DragAndDropAsync(string Email, int Id, int IndexValue)
        {
            await this.notesRepository.DragAndDrop(Email, Id, IndexValue);
            return "Index Added Successfully";
        }

        /// <summary>
        /// Restores all note.
        /// </summary>
        /// <param name="Email"></param>
        /// <returns></returns>
        public async Task<string> RestoreAllNote(string Email)
        {
            await this.notesRepository.RestoreAll(Email);
            return "Restore Successfully";
        }

        /// <summary>
        /// Removes all trash.
        /// </summary>
        /// <param name="Email"></param>
        /// <returns></returns>
        public async Task<string> RemoveAllTrash(string Email)
        {
            await this.notesRepository.RemoveTrash(Email);
            return "TRASH REMOVED";
        }

        /// <summary>
        /// Determines whether [is pin asynchronous] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<string> IsPinAsync(int id)
        {
            await this.notesRepository.IsPin(id);
            return "UPDATES SUCESSFULLY";
        }

        /// <summary>
        /// Uns the pin asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<string> UnPinAsync(int id)
        {
            await this.notesRepository.UnPin(id);
            return "UPDATES SUCESSFULLY";
        }

        /// <summary>
        /// Uploads the images.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="image">The image.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Remainders the value.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="reminder">The reminder.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="color">The color.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Searches the notes.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Adds the notes label asynchronous.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Gets the notes label.
        /// </summary>
        /// <param name="noteId">The note identifier.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets all label list asynchronous.
        /// </summary>
        /// <returns></returns>
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
