using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Components.DAL.DTO;
using FriendlyBudget.LocalClient.Core.Interfaces;

namespace FriendlyBudget.LocalClient.Components.DAL.Repositories
{
    class ExpenditureCategoryRepository : IRepository<ExpenditureCategory>
    {
        public IEnumerable<ExpenditureCategory> Items { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(ExpenditureCategory item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExpenditureCategory> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExpenditureCategory> GetByQuery(string query)
        {
            throw new NotImplementedException();
        }

        public ExpenditureCategory GetOne(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ExpenditureCategory item)
        {
            throw new NotImplementedException();
        }

        public void Update(ExpenditureCategory oldItem, ExpenditureCategory newItem)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<ExpenditureCategory> oldItems, IEnumerable<ExpenditureCategory> newItems)
        {
            throw new NotImplementedException();
        }
    }
}
