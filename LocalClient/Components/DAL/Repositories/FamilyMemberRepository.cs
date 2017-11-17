using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Components.Core.Interfaces;
using FriendlyBudget.LocalClient.Components.DAL.DTO;
using FriendlyBudget.LocalClient.Components.DAL.Database;

namespace FriendlyBudget.LocalClient.Components.DAL.Repositories
{
    class FamilyMemberRepository : IRepository<FamilyMember>
    {
        #region Fields

        private List<FamilyMember> _items;

        #endregion

        #region Properties

        public List<FamilyMember> Items
        {
            get { return _items; }
            set => _items = value;
        }

        #endregion

        #region Public Methods

        public void Add(FamilyMember item)
        {
            using(var context = new MainContext())
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
        }

        public IEnumerable<FamilyMember> GetAll()
        {
            using(var context = new MainContext())
            {
                IEnumerable<FamilyMember> familyMembers = context.FamilyMembers.AsEnumerable();
                UpdateItemsList(familyMembers);
                return familyMembers;
            }
        }

        public IEnumerable<FamilyMember> GetByQuery(string query)
        {
            using(var context = new MainContext())
            {
                IEnumerable<FamilyMember> familyMembers = context.FamilyMembers.SqlQuery(query);
                UpdateItemsList(familyMembers);
                return familyMembers;
            }
        }

        public FamilyMember GetOne(long id)
        {
            using(var context = new MainContext())
            {
                FamilyMember familyMember;
                var query = (from f in context.FamilyMembers
                             where f.Id == id
                             select f);

                familyMember = query.FirstOrDefault();

                UpdateItemsList(familyMember);

                return familyMember;
            }
        }

        public void Remove(FamilyMember item)
        {
            using(var context = new MainContext())
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(FamilyMember modifiedItem)
        {
            using(var context = new MainContext())
            {
                context.Entry(modifiedItem).State = System.Data.Entity.EntityState.Modified;
                UpdateItemsList(modifiedItem);
                context.SaveChanges();
            }
        }

        public void Update(IEnumerable<FamilyMember> modifiedItems)
        {
            using(var context = new MainContext())
            {
                foreach(FamilyMember modifiedItem in modifiedItems)
                {
                    context.Entry(modifiedItem).State = System.Data.Entity.EntityState.Modified;
                }

                UpdateItemsList(modifiedItems);
                context.SaveChanges();
            }
        }

        #endregion

        #region Methods

        private void UpdateItemsList(FamilyMember item)
        {
            Items.Clear();
            Items.Add(item);
        }

        private void UpdateItemsList(IEnumerable<FamilyMember> items)
        {
            Items = items.ToList();
        }

        #endregion
    }
}
