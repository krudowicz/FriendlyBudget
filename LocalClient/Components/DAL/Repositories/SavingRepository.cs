using FriendlyBudget.LocalClient.Components.Core.Interfaces;
using FriendlyBudget.LocalClient.Components.DAL.Database;
using FriendlyBudget.LocalClient.Components.DAL.Entities;
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
                context.Entry(item).State = System.Data.Entity.EntityState.Added;
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
            using(var context = new MainContext())
            {
                Saving saving;
                var query = (from s in context.Savings
                             where s.Id == id
                             select s);

                saving = query.FirstOrDefault();

                UpdateItemsList(saving);

                return saving;
            }
        }

        public void Remove(Saving item)
        {
            using(var context = new MainContext())
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(Saving modifiedItem)
        {
            using(var context = new MainContext())
            {
                context.Entry(modifiedItem).State = System.Data.Entity.EntityState.Modified;
                UpdateItemsList(modifiedItem);
                context.SaveChanges();
            }
        }

        public void Update(IEnumerable<Saving> modifiedItems)
        {
            using(var context = new MainContext())
            {
                foreach(Saving modifiedItem in modifiedItems)
                {
                    context.Entry(modifiedItem).State = System.Data.Entity.EntityState.Modified;
                }

                UpdateItemsList(modifiedItems);
                context.SaveChanges();
            }
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
