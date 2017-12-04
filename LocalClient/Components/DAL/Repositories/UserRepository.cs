using FriendlyBudget.LocalClient.Components.Core.Interfaces;
using FriendlyBudget.LocalClient.Components.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Components.DAL.Database;

namespace FriendlyBudget.LocalClient.Components.DAL.Repositories
{
    public class UserRepository : IRepository<User>
    {

        #region Fields

        private List<User> _items;

        #endregion

        #region Properties

        public List<User> Items
        {
            get { return _items; }
            set => _items = value;
        }

        #endregion

        #region Public Methods

        public void Add(User item)
        {
            using(var context = new MainContext())
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
        }

        public IEnumerable<User> GetAll()
        {
            using(var context = new MainContext())
            {
                IEnumerable<User> users = context.Users.AsEnumerable();
                UpdateItemsList(users);
                return users;
            }
        }

        public User GetByEmail(string email, bool found)
        {
            throw new NotImplementedException();
        }

        public User GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public User GetByLogin(string login, out bool found)
        {
            throw new NotImplementedException();
        }

        public User GetByLogin(string login)
        {
            throw new NotImplementedException();
        }

        //TODO: Think about moving it to private section to hide implementation.
        public IEnumerable<User> GetByQuery(string query)
        {
            using(var context = new MainContext())
            {
                IEnumerable<User> users = context.Users.SqlQuery(query);
                UpdateItemsList(users);
                return users;
            }
        }

        public User GetOne(ulong id)
        {
            using(var context = new MainContext())
            {
                User user;
                var query = (from u in context.Users
                             where u.Id == id
                             select u);
                user = query.FirstOrDefault();

                UpdateItemsList(user);

                return user;
            }
        }

        public void Remove(User item)
        {
            using(var context = new MainContext())
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(User modifiedItem)
        {
            using (var context = new MainContext())
            {
                context.Entry(modifiedItem).State = System.Data.Entity.EntityState.Modified;
                UpdateItemsList(modifiedItem);
                context.SaveChanges();
            }
        }

        public void Update(IEnumerable<User> modifiedItems)
        {
            using(var context = new MainContext())
            {
                foreach(User modifiedItem in modifiedItems)
                {
                    context.Entry(modifiedItem).State = System.Data.Entity.EntityState.Modified;
                }

                UpdateItemsList(modifiedItems);
                context.SaveChanges();
            }
        }

        #endregion

        #region Methods

        private void UpdateItemsList(User user)
        {
            Items.Clear();
            Items.Add(user);
        }

        private void UpdateItemsList(IEnumerable<User> users)
        {
            Items = users.ToList();
        }

        #endregion
    }
}
