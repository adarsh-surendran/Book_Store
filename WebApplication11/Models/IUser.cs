using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication11.Models
{
    public interface IUser
    {
        List<User> GetAllUsers();
        User GetUserByUserName(string name);
        User AddUser(User user);
        void DeleteUser(string name);
        User UpdateUser(User user);
        void UserStatus(string name,string status);
    }
}
