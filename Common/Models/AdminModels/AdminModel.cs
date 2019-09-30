using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Models.AdminModels
{
    public class AdminModel
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("UserModel")]
        public string Email { get; set; }
        public string LoginTime { get; set; }
    }
}
