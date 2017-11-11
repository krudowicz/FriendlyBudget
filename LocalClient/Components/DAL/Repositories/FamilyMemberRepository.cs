using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Core.Interfaces;
using FriendlyBudget.LocalClient.Components.DAL.DTO;

namespace FriendlyBudget.LocalClient.Components.DAL.Repositories
{
    class FamilyMemberRepository : IRepository<FamilyMember>
    {
        public IEnumerable<FamilyMember> Items { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(FamilyMember item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FamilyMember> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FamilyMember> GetByQuery(string query)
        {
            throw new NotImplementedException();
        }

        public FamilyMember GetOne(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(FamilyMember item)
        {
            throw new NotImplementedException();
        }

        public void Update(FamilyMember oldItem, FamilyMember newItem)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<FamilyMember> oldItems, IEnumerable<FamilyMember> newItems)
        {
            throw new NotImplementedException();
        }
    }
}
