using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StickyNotes.DAL;
using StickyNotes.Services.Interfaces;

namespace StickyNotes.Services
{
    public class NoteService : INoteService
    {
        private StickyNotesContext _db;

        public NoteService(StickyNotesContext db)
        {
            _db = db;
        }
        public bool SaveNote(Note note)
        {
            try
            {
                _db.Note.Add(note);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}