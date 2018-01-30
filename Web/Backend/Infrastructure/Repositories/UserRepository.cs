using FriendlyBudget.Web.Backend.Infrastructure.Database;
using FriendlyBudget.Web.Backend.Infrastructure.Entities;
using FriendlyBudget.Web.Backend.Infrastructure.Repositories.Interfaces;
using FriendlyBudget.Web.Backend.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FriendlyBudget.Web.Backend.Infrastructure.Repositories
{
    class UserRepository : IRepository<IUser>, IDisposable
    {
        private AuthenticationContext _context;
        private bool _disposed = false;
        public List<User> Users { get; set; }

        public UserRepository(AuthenticationContext context)
        {
            _context = context;
            Users = new List<User>();
        }

        public IList<IUser> GetAll()
        {
            List<IUser> users = new List<IUser>();
            
            foreach(IUser user in _context.Users)
            {
                users.Add(user);
            }

            Users.Clear();
            foreach(IUser user in users)
            {
                Users.Add(user);
            }

            return users;
        }

        public IUser GetOne(ulong id, out bool found)
        {
            found = false;
            User user = _context.Users.Find(id);

            if(user != null)
            {
                found = true;
            }

            Users.Clear();
            Users.Add(user);

            return user;
        }

        public IUser GetByEmail(string email, out bool found)
        {
            found = false;

            var query = from u in _context.Users
                        where u.Email == email
                        select u;

            User user = query.FirstOrDefault();

            if(user != null)
            {
                found = true;
            }

            Users.Clear();
            Users.Add(user);

            return user;
        }

        public void Add(IUser item)
        {
            item = (User)item;
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            _context.SaveChanges();
        }

        public void Modify(IUser item)
        {
            item = (User)item;
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(IUser item)
        {
            item = (User)item;
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if(!_disposed)
            {
                if(disposing)
                {
                    _context = null;
                    Users = null;
                }

                _disposed = true;
            }
        }
    }
}
