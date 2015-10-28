using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StickyNotes.DAL;

namespace StickyNotes.Services.Interfaces
{
    public interface INoteService
    {
        bool SaveNote(Note note);
    }
}
