using FriendlyBudget.LocalClient.Components.Core.Interfaces;
using FriendlyBudget.LocalClient.Components.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.DAL.Repositories
{
    class SavingRepository : IRepository<Saving>
    {
        public List<Saving> Items { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(Saving item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Saving> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Saving> GetByQuery(string query)
        {
            throw new NotImplementedException();
        }

        public Saving GetOne(ulong id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Saving item)
        {
            throw new NotImplementedException();
        }

        public void Update(Saving modifiedItem)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<Saving> modifiedItems)
        {
            throw new NotImplementedException();
        }
    }
}
