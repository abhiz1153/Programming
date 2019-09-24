﻿// --------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=INotesRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------------------------------------
namespace FundooRepository.Interface
{
    using Common.Models.NotesModels;
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
        List<NotesModel> GetNotes(int id);
        /// <summary>
        /// Determines whether the specified identifier is trash.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task IsTrash(int id);
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
        string UploadImages(int id, IFormFile image);
    }
}
