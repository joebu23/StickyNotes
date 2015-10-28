using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StickyNotes.Services.Interfaces;
using StickyNotes.DAL;

namespace StickyNotes.Services
{
    public class UserService : IUserService
    {
        private readonly StickyNotesContext _db;

        public UserService(StickyNotesContext dbContext)
        {
            _db = dbContext;
        }

        public User GetUserById(int id)
        {
            return _db.User.SingleOrDefault(x => x.Id == id);
        }

        public List<User> GetUsersByTeamId(int teamId)
        {
            return _db.User.Where(x => x.TeamId == teamId).ToList();
        }

        public int GetUserIdByEmail(string email)
        {
            return _db.User.SingleOrDefault(x => x.EmailAddress == email).Id;
        }
    }
}