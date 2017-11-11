using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Core.Interfaces;
using FriendlyBudget.LocalClient.Components.DAL.DTO;

namespace FriendlyBudget.LocalClient.Components.DAL.Repositories
{
    class IncomeCategoryRepository : IRepository<IncomeCategory>
    {
        public IEnumerable<IncomeCategory> Items { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(IncomeCategory item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IncomeCategory> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IncomeCategory> GetByQuery(string query)
        {
            throw new NotImplementedException();
        }

        public IncomeCategory GetOne(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(IncomeCategory item)
        {
            throw new NotImplementedException();
        }

        public void Update(IncomeCategory oldItem, IncomeCategory newItem)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<IncomeCategory> oldItems, IEnumerable<IncomeCategory> newItems)
        {
            throw new NotImplementedException();
        }
    }
}
