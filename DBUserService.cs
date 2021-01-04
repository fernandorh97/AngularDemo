using System;
using System.Collections.Generic;
using System.Linq;
using demo_app.db;

namespace demo_app
{
    public class DBUserService : IUserService
    {
        public void AddUser(User user)
        {
            using (var db = new db.pruebaContext()) {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            using (var db = new db.pruebaContext()) {
                return db.Users.ToArray();
            }
        }

        public User GetUser(int id)
        {
            using (var db = new db.pruebaContext()) {
                return db.Users.Find(id);
            }
        }

        public User GetUser(string email)
        {
            using (var db = new db.pruebaContext()) {
                return db.Users.Find(email);
            }
        }

        public int GetUserCount()
        {
            using (var db = new db.pruebaContext()) {
                return db.Users.Count();
            }
        }
    }
}
