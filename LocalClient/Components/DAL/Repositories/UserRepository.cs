using FriendlyBudget.LocalClient.Components.Core.Interfaces;
using FriendlyBudget.LocalClient.Components.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.DAL.Repositories
{
    public class UserRepository : IRepository<User>
    {
        public List<User> Items { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(User item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
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

        public IEnumerable<User> GetByQuery(string query)
        {
            throw new NotImplementedException();
        }

        public User GetOne(ulong id)
        {
            throw new NotImplementedException();
        }

        public void Remove(User item)
        {
            throw new NotImplementedException();
        }

        public void Update(User modifiedItem)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<User> modifiedItems)
        {
            throw new NotImplementedException();
        }
    }
}
