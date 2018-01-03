using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Components.Core.Interfaces;
using FriendlyBudget.LocalClient.Components.DAL.Database;
using FriendlyBudget.LocalClient.Components.Core.DTO;

namespace FriendlyBudget.LocalClient.Components.DAL.Repositories
{
    class ExpenditureRepository : IRepository<Expenditure>
    {
        #region Fields

        private List<Expenditure> _items;

        #endregion

        #region Properties

        public List<Expenditure> Items
        {
            get { return _items; }
            set => _items = value;
        }

        #endregion

        #region Public Methods

        public void Add(Expenditure item)
        {
            using (var context = new MainContext())
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
        }

        public IEnumerable<Expenditure> GetAll()
        {
            using (var context = new MainContext())
            {
                IEnumerable<Expenditure> expenditures = context.Expenditures.AsEnumerable();
                UpdateItemsList(expenditures);
                return expenditures;
            }
        }

        public IEnumerable<Expenditure> GetByQuery(string query)
        {
            using (var context = new MainContext())
            {
                IEnumerable<Expenditure> expenditures = context.Expenditures.SqlQuery(query);
                UpdateItemsList(expenditures);
                return expenditures;
            }
        }

        public Expenditure GetOne(ulong id)
        {
            using (var context = new MainContext())
            {
                Expenditure expenditure;
                var query = (from e in context.Expenditures
                             where e.Id == id
                             select e);

                expenditure = query.FirstOrDefault();

                UpdateItemsList(expenditure);

                return expenditure;
            }
        }

        public void Remove(Expenditure item)
        {
            using (var context = new MainContext())
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(Expenditure modifiedItem)
        {
            using (var context = new MainContext())
            {
                context.Entry(modifiedItem).State = System.Data.Entity.EntityState.Modified;
                UpdateItemsList(modifiedItem);
                context.SaveChanges();
            }
        }

        public void Update(IEnumerable<Expenditure> modifiedItems)
        {
            using (var context = new MainContext())
            {
                foreach (Expenditure modifiedItem in modifiedItems)
                {
                    context.Entry(modifiedItem).State = System.Data.Entity.EntityState.Modified;
                }

                UpdateItemsList(modifiedItems);
                context.SaveChanges();
            }
        }

        #endregion

        #region Methods

        private void UpdateItemsList(Expenditure item)
        {
            Items.Clear();
            Items.Add(item);
        }

        private void UpdateItemsList(IEnumerable<Expenditure> items)
        {
            Items = items.ToList();
        }

        #endregion
    }
}
