using System.Collections.Generic;
using demo_app.db;


namespace demo_app
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User GetUser(int id);
        User GetUser(string email);
        int GetUserCount();
        void AddUser(User user);
    }
}