using Common.Models.NotesModels;
using FundooRepository.DBContext;
using FundooRepository.Interface;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    public class NotesRepository : INotesRepository
    {
        private readonly UserContext userContext;

        public NotesRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }
        public Task AddNotes(NotesModel notesModel)
        {
            NotesModel notes = new NotesModel()
            {
                Email = notesModel.Email,
                Title = notesModel.Title,
                Description = notesModel.Description,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Images = notesModel.Images,
                Reminder = notesModel.Reminder,
                IsArchive = notesModel.IsArchive,
                IsTrash = notesModel.IsTrash,
                IsPin = notesModel.IsPin,
                Color = notesModel.Color
            };
            userContext.Notes.Add(notes);
            return Task.Run(() => userContext.SaveChanges());
        }
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
        public Task UpdateNotes(NotesModel notesModel)
        {
            var note = userContext.Notes.Where(r => r.Id == notesModel.Id).SingleOrDefault();
            if (note != null)
            {

                note.Email = notesModel.Email;
                note.Title = notesModel.Title;
                note.Description = notesModel.Description;
                note.ModifiedDate = DateTime.Now;
                note.Images = notesModel.Images;
                note.Reminder = notesModel.Reminder;
                note.IsArchive = notesModel.IsArchive;
                note.IsTrash = notesModel.IsTrash;
                note.IsPin = notesModel.IsPin;
                note.Color = notesModel.Color;

                userContext.Notes.Update(note);
            }
            return Task.Run(() => userContext.SaveChanges());
        }
        public List<NotesModel> GetList()
        {
            return this.userContext.Notes.ToList<NotesModel>();
        }
        public List<NotesModel> GetNotes(int id)
        {
            var note = userContext.Notes.Where(r => r.Id == id).SingleOrDefault();
            if (note != null)
            {
                return userContext.Notes.Where(r => r.Id == id).ToList();
            }
            return null;
        }
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
    }
}
