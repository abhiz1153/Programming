// --------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------------------------------------
namespace FundooRepository.Repository
{
    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;
    using Common.Models.CollaboratorModel;
    using Common.Models.NotesLabelsModels;
    using FundooRepository.DBContext;
    using FundooRepository.Interface;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using StackExchange.Redis;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    /// <summary>
    /// Public Class NotesRepository
    /// </summary>
    /// <seealso cref="FundooRepository.Interface.INotesRepository" />
    public class NotesRepository : INotesRepository
    {
        /// <summary>
        /// The user context
        /// </summary>
        private readonly UserContext userContext;
        /// <summary>
        /// Initializes a new instance of the <see cref="NotesRepository"/> class.
        /// </summary>
        /// <param name="userContext">The user context.</param>
        public NotesRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }
        /// <summary>
        /// Adds the notes.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        public Task AddNotes(NotesModel notesModel)
        {
            var user = userContext.Register.Where(p => p.Email == notesModel.Email).Single();
            {

                NotesModel notes = new NotesModel()
                {
                    Email = notesModel.Email,
                    Title = notesModel.Title,
                    Description = notesModel.Description,
                    CreatedDate = DateTime.Now,
                    Images = notesModel.Images,
                    Reminder = notesModel.Reminder,
                    IsArchive = notesModel.IsArchive,
                    IsTrash = notesModel.IsTrash,
                    IsPin = false,
                    Color = 0.ToString()
                };
                userContext.Notes.Add(notes);
                user.TotalNotes++;
            }
            return Task.Run(() => userContext.SaveChanges());
        }
        /// <summary>
        /// Deletes the notes.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Task DeleteNotes(int id)
        {            
            var note = userContext.Notes.Where(r => r.Id == id).SingleOrDefault();
            if (note != null)
            {
                var user = userContext.Register.Where(p => p.Email == note.Email).Single();
                userContext.Notes.Remove(note);
                user.TotalNotes--;
                userContext.SaveChanges();
                return Task.Run(() => userContext.SaveChanges());
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Updates the notes.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        public Task UpdateNotes(NotesModel notesModel)
        {
            var note = userContext.Notes.Where(r => r.Id == notesModel.Id).SingleOrDefault();
            if (note != null)
            {

                note.Email = notesModel.Email;
                note.Title = notesModel.Title;
                note.Description = notesModel.Description;
                note.ModifiedDate = DateTime.Now;
                userContext.Notes.Update(note);

            }
            return Task.Run(() => userContext.SaveChanges());
        }
        public Task DragAndDrop(string Email, int PreviousIndex, int IndexValue)
        {
            var data = userContext.Notes.Where(n => n.Email == Email).ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    if (item.IndexValue == PreviousIndex)
                    {
                        item.IndexValue = IndexValue;
                        userContext.Notes.Update(item);
                    }
                    else if (IndexValue >= item.IndexValue)
                    {
                        item.IndexValue = item.IndexValue + 1;
                        userContext.Notes.Update(item);
                    }
                }

            }
            return Task.Run(() => userContext.SaveChanges());
        }
        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        public List<NotesModel> GetList()
        {
            return this.userContext.Notes.ToList<NotesModel>();
        }
        /// <summary>
        /// Gets the notes.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public List<NotesModel> GetNotes(string Email)
        {
            var note = userContext.Notes.Where(r => r.Email == Email).First();
            if (note != null)
            {
                return userContext.Notes.Where(r => r.Email == Email && r.IsArchive == false && r.IsTrash == false).ToList();
            }
            return null;
        }
        public List<NotesModel> GetReminder(string Email)
        {
            var note = userContext.Notes.Any(r => r.Email == Email && r.Reminder != null);
            if (note)
            {
                return userContext.Notes.Where(r => r.Email == Email && r.Reminder != null).ToList();
            }
            return null;
        }
        /// <summary>
        /// Determines whether the specified identifier is trash.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Task IsTrash(int id)
        {
            var result = this.userContext.Notes.Where(n => n.Id == id).SingleOrDefault();
            if (result != null)
            {
                result.IsTrash = true;
                return Task.Run(() => userContext.SaveChangesAsync());

            }
            return null;
        }
        public List<NotesModel> GetTrashList(string Email)
        {
            var result = this.userContext.Notes.Any(n => n.Email == Email && n.IsTrash == true);
            if (result)
            {
                return this.userContext.Notes.Where(n => n.Email == Email && n.IsTrash == true).ToList();
            }
            return null;
        }
        /// <summary>
        /// Restores the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Task Restore(int id)
        {
            var result = this.userContext.Notes.Where(n => n.Id == id && n.IsTrash == true).SingleOrDefault();
            if (result != null)
            {
                result.IsTrash = false;
                return Task.Run(() => userContext.SaveChangesAsync());

            }
            return null;
        }
        public Task RestoreAll(string Email)
        {
            var data = this.userContext.Notes.Where(n => n.Email == Email && n.IsTrash == true).ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    item.IsTrash = false;
                }
                return Task.Run(() => userContext.SaveChangesAsync());
            }
            return null;
        }
        /// <summary>
        /// Removes the trash.
        /// </summary>
        /// <returns></returns>
        public Task RemoveTrash(string Email)
        {
            var data = this.userContext.Notes.Where(n => n.Email == Email && n.IsTrash == true).ToList();
            if (data != null)
            {
                foreach (var items in data)
                {
                    this.userContext.Notes.Remove(items);
                }
                return Task.Run(() => userContext.SaveChangesAsync());
            }
            return null;
        }

        /// <summary>
        /// Determines whether the specified identifier is archive.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Task IsArchive(int id)
        {
            var result = this.userContext.Notes.Where(n => n.Id == id).SingleOrDefault();
            if (result != null)
            {
                result.IsArchive = true;
                return Task.Run(() => userContext.SaveChangesAsync());
            }
            return null;
        }
        /// <summary>
        /// Uns the archive.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Task UnArchive(int id)
        {
            var result = this.userContext.Notes.Where(n => n.Id == id && n.IsArchive == true).SingleOrDefault();
            if (result != null)
            {
                result.IsArchive = false;
                return Task.Run(() => userContext.SaveChangesAsync());

            }
            return null;
        }
        public List<NotesModel> ArchiveNote(string Email)
        {
            var result = this.userContext.Notes.Any(n => n.Email == Email && n.IsArchive == true);
            if (result)
            {
                return userContext.Notes.Where(n => n.Email == Email && n.IsArchive == true).ToList();
            }
            return null;
        }
        public List<NotesModel> ArchiveList()
        {
            var result = this.userContext.Notes.Where(n => n.IsArchive == true).SingleOrDefault();
            if (result != null)
            {
                return this.userContext.Notes.ToList<NotesModel>();
            }
            return null;
        }
        /// <summary>
        /// Determines whether the specified identifier is pin.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Task IsPin(int id)
        {
            var result = this.userContext.Notes.Where(n => n.Id == id).SingleOrDefault();
            if (result != null)
            {
                result.IsPin = true;
                return Task.Run(() => userContext.SaveChangesAsync());

            }
            return null;
        }
        /// <summary>
        /// Uns the pin.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Task UnPin(int id)
        {
            var result = this.userContext.Notes.Where(n => n.Id == id && n.IsPin == true).SingleOrDefault();
            if (result != null)
            {
                result.IsPin = false;
                return Task.Run(() => userContext.SaveChangesAsync());

            }
            return null;
        }
        /// <summary>
        /// Uploads the images.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="image">The image.</param>
        /// <returns></returns>
        public string UploadImages(int id, IFormFile image)
        {
            var stream = image.OpenReadStream();
            var name = image.FileName;
            CloudinaryDotNet.Account account = new CloudinaryDotNet.Account("abhishek-sharma", "558464398819742", "y0fRr8Oww5WMgxaW73er-0pQ0iY");
            CloudinaryDotNet.Cloudinary cloudinary = new CloudinaryDotNet.Cloudinary(account);
            var uploadfile = new ImageUploadParams()
            {
                File = new FileDescription(name, stream)
            };
            var uploadResult = cloudinary.Upload(uploadfile);
            var data = this.userContext.Notes.Where(n => n.Id == id).SingleOrDefault();
            data.Images = uploadResult.Uri.ToString();
            int result = 0;
            try
            {
                result = this.userContext.SaveChanges();
                return data.Images;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public int Remainder(int id, string reminder)
        {
            var user = this.userContext.Notes.Where(r => r.Id == id).SingleOrDefault();
            if (user != null)
            {
                user.Reminder = reminder.ToString();
                return userContext.SaveChanges();
            }
            return 0;
        }
        public Task Color(int id, string color)
        {
            var result = this.userContext.Notes.Where(n => n.Id == id).SingleOrDefault();
            if (result != null)
            {
                result.Color = color;
                return Task.Run(() => userContext.SaveChangesAsync());

            }
            return null;
        }
        public List<NotesModel> Search(string title)
        {
            var note = userContext.Notes.Where(r => r.Title == title).Single();
            if (note != null)
            {
                return userContext.Notes.Where(r => r.Title == title).ToList();
            }
            return null;
        }
        /// <summary>
        /// Adds the notes.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        /// <summary>
        /// Adds the notes label.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Task AddNotesLabel(NoteLabelModel model)
        {
            try
            {
                NoteLabelModel data = new NoteLabelModel
                {
                    LableId = model.LableId,
                    NoteId = model.NoteId,
                    Label = model.Label
                };
                userContext.NotesLabelModels.Add(data);
                return Task.Run(() => userContext.SaveChanges());
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Gets the notes label.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<NoteLabelModel> GetNotesLabel(int noteid)
        {
            var result = this.userContext.NotesLabelModels.Any(n => n.NoteId == noteid);
            if (result)
            {
                return this.userContext.NotesLabelModels.Where(n => n.NoteId == noteid).ToList();

            }
            return null;
        }

        /// <summary>
        /// Deletes the notes label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string DeleteNotesLabel(int id)
        {
            var label = this.userContext.NotesLabelModels.Where<NoteLabelModel>(t => t.NoteId == id).FirstOrDefault();
            try
            {
                this.userContext.NotesLabelModels.Remove(label); var result = this.userContext.SaveChanges();
                return result.ToString();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        public List<NoteLabelModel> GetLabelList()
        {
            return this.userContext.NotesLabelModels.ToList<NoteLabelModel>();
        }
    }
}