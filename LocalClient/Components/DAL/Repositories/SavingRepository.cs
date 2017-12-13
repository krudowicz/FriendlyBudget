using FriendlyBudget.LocalClient.Components.Core.Interfaces;
using FriendlyBudget.LocalClient.Components.DAL.Database;
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
        #region Fields

        private List<Saving> _items { get; set; }

        #endregion

        #region Properties

        public List<Saving> Items
        {
            get { return _items; }
            set => _items = value;
        }

        #endregion

        #region Public Methods

        public void Add(Saving item)
        {
            using(var context = new MainContext())
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Added();
                context.SaveChanges();
            }
        }

        public IEnumerable<Saving> GetAll()
        {
            using(var context = new MainContext())
            {
                IEnumerable<Saving> savings = context.Savings.AsEnumerable();
                UpdateItemsList(savings);
                return savings;
            }
        }

        public IEnumerable<Saving> GetByQuery(string query)
        {
            using(var context = new MainContext())
            {
                IEnumerable<Saving> savings = context.Savings.SqlQuery(query);
                UpdateItemsList(savings);
                return savings;
            }
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

        #endregion

        #region Methods

        private void UpdateItemsList(Saving item)
        {
            Items.Clear();
            Items.Add(item);
        }

        private void UpdateItemsList(IEnumerable<Saving> items)
        {
            Items = items.ToList();
        }

        #endregion
    }
}
