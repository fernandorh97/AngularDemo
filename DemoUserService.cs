using System.Collections.Generic;
using System.Linq;
using demo_app.db;

namespace demo_app
{
    public class DemoUserService : IUserService
    {
        private List<User> users = new List<User>();
        public DemoUserService()
        {
            users.Add(new User{UserId=1, Email="test@test.com", Password="ola"});
        }

        public void AddUser(User user)
        {
            user.UserId = users.Max(x => x.UserId)+1;
            users.Add(user);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return users.ToArray();
        }

        public User GetUser(string email)
        {
            return users.Find(x => x.Email == email);
        }

        public User GetUser(int id)
        {
            return users.Find(x => x.UserId == id);
        }

        public int GetUserCount()
        {
            return users.Count;
        }
    }
}