using FriendlyBudget.Shared.Models.Database;
using FriendlyBudget.Shared.Models.DTO;
using FriendlyBudget.Shared.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FriendlyBudget.Shared.Models.Repositories
{
    public class UserRepository : IRepository<User>
    {
        public void Add(User item)
        {
            using(var context = new MainContext())
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(User item)
        {
            using(var context = new MainContext())
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public User Get(long id)
        {
            using(var context = new MainContext())
            {
                User user = context.Users.Find(id);
                return user;
            }
        }

        public IEnumerable<User> GetAll()
        {
            using (var context = new MainContext())
            {
                IEnumerable<User> users = context.Users.AsEnumerable();
                return users;
            }
        }

        public void Update(User item)
        {
            using (var context = new MainContext())
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}