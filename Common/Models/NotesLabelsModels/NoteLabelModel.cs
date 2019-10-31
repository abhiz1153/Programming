using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.NotesLabelsModels
{
    public class NoteLabelModel
    {
        /// <summary>
        /// The identifier
        /// </summary>
        private int id;

        /// <summary>
        /// The lable identifier
        /// </summary>
        private int lableId;

        /// <summary>
        /// The note identifier
        /// </summary>
        private int noteId;

        /// <summary>
        /// The email
        /// </summary>
        private string label;

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        /// <summary>
        /// Gets or sets the lable identifier.
        /// </summary>
        /// <value>
        /// The lable identifier.
        /// </value>
        public int LableId
        {
            get
            {
                return this.lableId;
            }
            set
            {
                this.lableId = value;
            }
        }

        /// <summary>
        /// Gets or sets the note identifier.
        /// </summary>
        /// <value>
        /// The note identifier.
        /// </value>
        public int NoteId
        {
            get
            {
                return this.noteId;
            }
            set
            {
                this.noteId = value;
            }
        }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Label
        {
            get
            {
                return this.label;
            }
            set
            {
                this.label = value;
            }
        }
    }
}
