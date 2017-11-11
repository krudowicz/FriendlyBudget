using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Components.DAL.DTO;
using FriendlyBudget.LocalClient.Core.Interfaces;

namespace FriendlyBudget.LocalClient.Components.DAL.Repositories
{
    class ExpenditureRepository : IRepository<Expenditure>
    {
        public IEnumerable<Expenditure> Items { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(Expenditure item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Expenditure> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Expenditure> GetByQuery(string query)
        {
            throw new NotImplementedException();
        }

        public Expenditure GetOne(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Expenditure item)
        {
            throw new NotImplementedException();
        }

        public void Update(Expenditure oldItem, Expenditure newItem)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<Expenditure> oldItems, IEnumerable<Expenditure> newItems)
        {
            throw new NotImplementedException();
        }
    }
}
