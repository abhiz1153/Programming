// ----------------------------------------------------------------------------------------------------------------------------------
// <copyright file=CollaboratorsModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// ----------------------------------------------------------------------------------------------------------------------------------
namespace Common.Models.CollaboratorsModels
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// public class CollaboratorsModel
    /// </summary>
    public class CollaboratorsModel
    {
        /// <summary>
        /// The identifier
        /// </summary>
        private int id;

        /// <summary>
        /// The sender email
        /// </summary>
        private string senderEmail;

        /// <summary>
        /// The note identifier
        /// </summary>
        private int noteId;

        /// <summary>
        /// The reciver email
        /// </summary>
        private string reciverEmail;

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id
        {
            set { this.id = value; }
            get { return this.id; }
        }

        /// <summary>
        /// Gets or sets the sender email.
        /// </summary>
        /// <value>
        /// The sender email.
        /// </value>
        [ForeignKey("UserModel")]
        [EmailAddress]
        public string SenderEmail
        {
            set { this.senderEmail = value; }
            get { return this.senderEmail; }
        }

        /// <summary>
        /// Gets or sets the note identifier.
        /// </summary>
        /// <value>
        /// The note identifier.
        /// </value>
        public int NoteId
        {
            set { this.noteId = value; }
            get { return this.noteId; }
        }

        /// <summary>
        /// Gets or sets the reciver email.
        /// </summary>
        /// <value>
        /// The reciver email.
        /// </value>
        public string ReciverEmail
        {
            set { this.reciverEmail = value; }
            get { return this.reciverEmail; }
        }
    }
}
