// --------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=INotes.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------------------------------------
namespace BussinessManager.Interface
{
    using Common.Models.NotesModels;
    using Microsoft.AspNetCore.Http;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    /// <summary>
    /// Public Interface For INotes
    /// </summary>
    public interface INotes
    {
        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        Task<string> AddAsync(NotesModel notesModel);
        /// <summary>
        /// Deletes the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<string> DeleteAsync(int id);
        /// <summary>
        /// Updates the asynchronous.
        /// </summary>
        /// <param name="notesModel">The notes model.</param>
        /// <returns></returns>
        Task<string> UpdateAsync(NotesModel notesModel);
        /// <summary>
        /// Gets all list asynchronous.
        /// </summary>
        /// <returns></returns>
        List<NotesModel> GetAllListAsync();
        /// <summary>
        /// Gets the notes asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        List<NotesModel> GetNotesAsync(int id);
        /// <summary>
        /// Determines whether [is archive asynchronous] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<string> IsArchiveAsync(int id);
        /// <summary>
        /// Uns the archive asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<string> UnArchiveAsync(int id);
        /// <summary>
        /// Determines whether [is trash asynchronous] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<string> IsTrashAsync(int id);
        /// <summary>
        /// Restores the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<string> RestoreAsync(int id);
        /// <summary>
        /// Determines whether [is pin asynchronous] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<string> IsPinAsync(int id);
        /// <summary>
        /// Uns the pin asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<string> UnPinAsync(int id);
        /// <summary>
        /// Uploads the images.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="image">The image.</param>
        /// <returns></returns>
        string UploadImages(int id, IFormFile image);
    }
}