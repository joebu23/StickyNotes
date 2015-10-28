using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StickyNotes_Admin.DAL.Models
{
    public class Team
    {
        [Key]
        public Int32 Id { get; set; }

        public String Name { get; set; }

        public String AdminId { get; set; }
    }
}