using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StickyNotes.DAL;
using StickyNotes.Services;

namespace StickyNotesDesktop
{
    public partial class Form1 : Form
    {
        private UserService _userService;
        private NoteService _noteService;

        public Form1()
        {
            var db = new StickyNotesContext();
            _userService = new UserService(db);
            _noteService = new NoteService(db);

            InitializeComponent();

            var users = _userService.GetUsersByTeamId(1);

            foreach (var user in users)
            {
                NameBox.Items.Add(user.EmailAddress);
            }
        }

        private void SaveNote_Click(object sender, EventArgs e)
        {
            var recipientId = _userService.GetUserIdByEmail(NameBox.Text.Trim());
            var newNote = new Note
            {
                Body = NoteText.Text,
                From = "testSave",
                To = recipientId
            };
            if (_noteService.SaveNote(newNote))
            {
                NoteText.Text = "";
            }
        }
    }
}
