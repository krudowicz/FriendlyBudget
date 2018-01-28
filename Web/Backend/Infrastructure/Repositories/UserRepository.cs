using FriendlyBudget.Web.Backend.Infrastructure.Database;
using FriendlyBudget.Web.Backend.Infrastructure.Entities;
using FriendlyBudget.Web.Backend.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Infrastructure.Repositories
{
    class UserRepository : IRepository<User>, IDisposable
    {
        private AuthenticationContext _context;

        public UserRepository(AuthenticationContext context)
        {
            _context = context;
        }

        public IList<User> GetAll()
        {
            List<User> users = new List<User>();
            
            foreach(User user in _context.Users)
            {
                users.Add(user);
            }

            return users;
        }

        public User GetOne(ulong id, out bool found)
        {
            found = false;
            User user = _context.Users.Find(id);

            if(user != null)
            {
                found = true;
            }

            return user;
        }

        public void Add(User item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            _context.SaveChanges();
        }

        public void Modify(User item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(User item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        private void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }
    }
}
