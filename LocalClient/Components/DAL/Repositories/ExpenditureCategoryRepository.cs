using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Components.DAL.DTO;
using FriendlyBudget.LocalClient.Components.DAL.Database;
using FriendlyBudget.LocalClient.Core.Interfaces;

namespace FriendlyBudget.LocalClient.Components.DAL.Repositories
{
    class ExpenditureCategoryRepository : IRepository<ExpenditureCategory>
    {
        #region Fields

        private List<ExpenditureCategory> _items;

        #endregion

        #region Properties

        public List<ExpenditureCategory> Items
        {
            get { return _items; }
            set => _items = value;
        }

        #endregion

        #region Public Methods

        public void Add(ExpenditureCategory item)
        {
            using (var context = new MainContext())
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
        }

        public IEnumerable<ExpenditureCategory> GetAll()
        {
            using (var context = new MainContext())
            {
                IEnumerable<ExpenditureCategory> expenditureCategories = context.ExpenditureCategories.AsEnumerable();
                UpdateItemsList(expenditureCategories);
                return expenditureCategories;
            }
        }

        public IEnumerable<ExpenditureCategory> GetByQuery(string query)
        {
            using (var context = new MainContext())
            {
                IEnumerable<ExpenditureCategory> expenditureCategories = context.ExpenditureCategories.SqlQuery(query);
                UpdateItemsList(expenditureCategories);
                return expenditureCategories;
            }
        }

        public ExpenditureCategory GetOne(long id)
        {
            using (var context = new MainContext())
            {
                ExpenditureCategory expenditureCategory;
                var query = (from c in context.ExpenditureCategories
                             where c.Id == id
                             select c);

                expenditureCategory = query.FirstOrDefault();

                UpdateItemsList(expenditureCategory);

                return expenditureCategory;
            }
        }

        public void Remove(ExpenditureCategory item)
        {
            using (var context = new MainContext())
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(ExpenditureCategory modifiedItem)
        {
            using (var context = new MainContext())
            {
                context.Entry(modifiedItem).State = System.Data.Entity.EntityState.Modified;
                UpdateItemsList(modifiedItem);
                context.SaveChanges();
            }
        }

        public void Update(IEnumerable<ExpenditureCategory> modifiedItems)
        {
            using (var context = new MainContext())
            {
                foreach (ExpenditureCategory modifiedItem in modifiedItems)
                {
                    context.Entry(modifiedItem).State = System.Data.Entity.EntityState.Modified;
                }

                UpdateItemsList(modifiedItems);
                context.SaveChanges();
            }
        }

        #endregion

        #region Methods

        private void UpdateItemsList(ExpenditureCategory item)
        {
            Items.Clear();
            Items.Add(item);
        }

        private void UpdateItemsList(IEnumerable<ExpenditureCategory> items)
        {
            Items = items.ToList();
        }

        #endregion
    }
}
