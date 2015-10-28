using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StickyNotes.DAL
{
    public class Note
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("To")]
        public virtual User User { get; set; }
        public int To { get; set; }
        
        public string From { get; set; }
        
        public string Body { get; set; }
    }
}