// --------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=INotesRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------------------------------------
namespace FundooRepository.Interface
{
    using Common.Models.CollaboratorModel;
    using Common.Models.NotesLabelsModels;
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Public Interface INotesRepository
    /// </summary>
    public interface INotesRepository
    {
        /// <summary>
        /// Adds the notes.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        Task AddNotes(NotesModel notesModel);

        /// <summary>
        /// Deletes the notes.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task DeleteNotes(int id);

        /// <summary>
        /// Updates the notes.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        Task UpdateNotes(NotesModel notesModel);

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        List<NotesModel> GetList();

        /// <summary>
        /// Gets the notes.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        List<NotesModel> GetNotes(string Email);

        /// <summary>
        /// Determines whether the specified identifier is trash.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task IsTrash(int id);

        /// <summary>
        /// Gets the reminder.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        List<NotesModel> GetReminder(string Email);

        /// <summary>
        /// Gets the trash list.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        List<NotesModel> GetTrashList(string Email);

        /// <summary>
        /// Determines whether the specified identifier is archive.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task IsArchive(int id);

        /// <summary>
        /// Determines whether the specified identifier is pin.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task IsPin(int id);

        /// <summary>
        /// Uns the pin.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task UnPin(int id);

        /// <summary>
        /// Restores the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task Restore(int id);

        /// <summary>
        /// Uns the archive.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task UnArchive(int id);

        /// <summary>
        /// Archives the note.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        List<NotesModel> ArchiveNote(string Email);

        /// <summary>
        /// Archives the list.
        /// </summary>
        /// <returns></returns>
        List<NotesModel> ArchiveList();

        /// <summary>
        /// Uploads the images.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="image">The image.</param>
        /// <returns></returns>
        string UploadImages(int id, IFormFile image);

        /// <summary>
        /// Reminders the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="reminder">The date time.</param>
        /// <returns></returns>
        int Remainder(int id, string reminder);

        /// <summary>
        /// Restores all.
        /// </summary>
        /// <returns></returns>
        Task RestoreAll(string Email);

        /// <summary>
        /// Removes the trash.
        /// </summary>
        /// <returns></returns>
        Task RemoveTrash(string Email);

        /// <summary>
        /// Colors the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="color">The color.</param>
        /// <returns></returns>
        Task Color(int id, string color);

        /// <summary>
        /// Searches the specified title.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <returns></returns>
        List<NotesModel> Search(string title);

        /// <summary>
        /// Adds the notes label.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        Task AddNotesLabel(NoteLabelModel model);

        /// <summary>
        /// Gets the notes label.
        /// </summary>
        /// <param name="noteid">The noteid.</param>
        /// <returns></returns>
        List<NoteLabelModel> GetNotesLabel(int noteid);

        /// <summary>
        /// Deletes the notes label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        string DeleteNotesLabel(int id);

        /// <summary>
        /// Gets the label list.
        /// </summary>
        /// <returns></returns>
        List<NoteLabelModel> GetLabelList();

        /// <summary>
        /// Drags the and drop.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <param name="Id">The identifier.</param>
        /// <param name="IndexValue">The index value.</param>
        /// <returns></returns>
        Task DragAndDrop(string Email, int Id, int IndexValue);
    }
}
