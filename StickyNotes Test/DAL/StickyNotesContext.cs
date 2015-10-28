using Microsoft.AspNet.Identity.EntityFramework;
using StickyNotes.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StickyNotes.DAL
{
    public class StickyNotesContext : IdentityDbContext<ApplicationUser>
    {
        public StickyNotesContext()
            : base("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StickyNotesContext, StickyNotes.Migrations.Configuration>());
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


//public OrionContext()
//            : base("DefaultConnection", throwIfV1Schema: false)
//        {
//            Database.SetInitializer(new MigrateDatabaseToLatestVersion<OrionContext, Orion.Services.Migrations.Configuration>());
//        }

//        public static OrionContext Create()
//        {
//            return new OrionContext();
//        }