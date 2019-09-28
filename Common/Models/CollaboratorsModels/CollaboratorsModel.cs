using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Models.CollaboratorsModels
{
    public class CollaboratorsModel
    {
        public int Id { get; set; }
        [ForeignKey("UserModel")]
        [EmailAddress]
        public string SenderEmail { get; set; }
        public int NoteId { get; set; }    
        public string ReciverEmail { get; set; }
    }
}
