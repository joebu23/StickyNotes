using Microsoft.AspNet.Identity.EntityFramework;
using StickyNotes_Admin.DAL.Models;
using StickyNotes_Admin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StickyNotes_Admin.DAL
{
    public class StickyNotesContext : IdentityDbContext<ApplicationUser>
    {
        public StickyNotesContext()
            : base("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StickyNotesContext, StickyNotes_Admin.Migrations.Configuration>());
        }

        public static StickyNotesContext Create()
        {
            return new StickyNotesContext();
        }

        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Note> Note { get; set; }
    }
}
