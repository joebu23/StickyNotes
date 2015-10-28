using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StickyNotes_Admin.DAL.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public String EmailAddress { get; set; }

        public String UserName { get; set; }

        [ForeignKey("TeamId")]
        public virtual Team Team { get; set; }

        public Int32 TeamId { get; set; }
    }
}