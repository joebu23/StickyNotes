using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using StickyNotes_Admin.Models;

namespace StickyNotes_Admin.DAL.Models
{
    public class Team
    {
        [Key]
        public Int32 Id { get; set; }

        public String Name { get; set; }

        public string AdminId { get; set; }

    }
}