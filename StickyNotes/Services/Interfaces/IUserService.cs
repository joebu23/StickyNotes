using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StickyNotes.DAL;

namespace StickyNotes.Services.Interfaces
{
    public interface IUserService
    {
        User GetUserById(int id);
        List<User> GetUsersByTeamId(int teamId);
        Int32 GetUserIdByEmail(string email);
    }
}
