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
            NotesModel notes = new NotesModel()
            {
                Email = notesModel.Email,
                Title = notesModel.Title,
                Description = notesModel.Description,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Images = null,
                Reminder = null,
                IsArchive = false,
                IsTrash = false,
                IsPin = false,
                Color = null
            };
         
            userContext.Notes.Add(notes);
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
                userContext.Notes.Remove(note);
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
        public List<NotesModel> GetNotes(int id)
        {
            var note = userContext.Notes.Where(r => r.Id == id).SingleOrDefault();
            if (note != null)
            {
                return userContext.Notes.Where(r => r.Id == id).ToList();
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
        public List<NotesModel> GetTrashList()
        {
            var result = this.userContext.Notes.Where(n => n.IsTrash == true).SingleOrDefault();
            if (result != null)
            {
                return this.userContext.Notes.ToList<NotesModel>();
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
        public Task RestoreAll()
        {
            var data = from notes in this.userContext.Notes where notes.IsTrash == true select notes;
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
        public Task RemoveTrash()
        {
            var data = from notes in this.userContext.Notes where notes.IsTrash == true select notes;
            if( data != null)
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
            var  uploadResult = cloudinary.Upload(uploadfile);
            var data = this.userContext.Notes.Where(n => n.Id == id).SingleOrDefault();
            data.Images = uploadResult.Uri.ToString();
            int result = 0;
            try
            {
                result = this.userContext.SaveChanges();
                return data.Images;
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
        public int Remainder(int id,string reminder)
        {
            var user = this.userContext.Notes.Where(r => r.Id == id).SingleOrDefault();
            if(user != null)
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
    }
}