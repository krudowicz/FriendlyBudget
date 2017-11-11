using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Components.DAL.DTO;
using FriendlyBudget.LocalClient.Core.Interfaces;

namespace FriendlyBudget.LocalClient.Components.DAL.Repositories
{
    class IncomeRepository : IRepository<Income>
    {
        public IEnumerable<Income> Items { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(Income item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Income> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Income> GetByQuery(string query)
        {
            throw new NotImplementedException();
        }

        public Income GetOne(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Income item)
        {
            throw new NotImplementedException();
        }

        public void Update(Income oldItem, Income newItem)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<Income> oldItems, IEnumerable<Income> newItems)
        {
            throw new NotImplementedException();
        }
    }
}
