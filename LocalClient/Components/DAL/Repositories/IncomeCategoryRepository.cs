using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Components.Core.Interfaces;
using FriendlyBudget.LocalClient.Components.DAL.Database;
using FriendlyBudget.LocalClient.Components.DAL.DTO;

namespace FriendlyBudget.LocalClient.Components.DAL.Repositories
{
    class IncomeCategoryRepository : IRepository<IncomeCategory>
    {
        private List<IncomeCategory> _items;

        public List<IncomeCategory> Items
        {
            get { return _items; }
            set => _items = value;
        }

        public void Add(IncomeCategory item)
        {
            using(var context = new MainContext())
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
        }

        public IEnumerable<IncomeCategory> GetAll()
        {
            using(var context = new MainContext())
            {
                IEnumerable<IncomeCategory> incomeCategories = context.IncomeCategories.AsEnumerable();
                UpdateItemsList(incomeCategories);
                return incomeCategories;
            }
        }

        public IEnumerable<IncomeCategory> GetByQuery(string query)
        {
            using(var context = new MainContext())
            {
                IEnumerable<IncomeCategory> incomeCategories = context.IncomeCategories.SqlQuery(query);
                UpdateItemsList(incomeCategories);
                return incomeCategories;
            }
        }

        public IncomeCategory GetOne(long id)
        {
            using(var context = new MainContext())
            {
                IncomeCategory incomeCategory;
                var query = (from c in context.IncomeCategories
                             where c.Id == id
                             select c);
                incomeCategory = query.FirstOrDefault();
                return incomeCategory;
            }
        }

        public void Remove(IncomeCategory item)
        {
            using(var context = new MainContext())
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(IncomeCategory modifiedItem)
        {
            using(var context = new MainContext())
            {
                context.Entry(modifiedItem).State = System.Data.Entity.EntityState.Modified;
                UpdateItemsList(modifiedItem);
                context.SaveChanges();
            }
        }

        public void Update(IEnumerable<IncomeCategory> modifiedItems)
        {
            using(var context = new MainContext())
            {
                foreach(IncomeCategory modifiedItem in modifiedItems)
                {
                    context.Entry(modifiedItem).State = System.Data.Entity.EntityState.Modified;
                }

                UpdateItemsList(modifiedItems);
                context.SaveChanges();
            }
        }

        private void UpdateItemsList(IncomeCategory item)
        {
            Items.Clear();
            Items.Add(item);
        }

        private void UpdateItemsList(IEnumerable<IncomeCategory> items)
        {
            Items.Clear();
            Items = items.ToList();
        }
    }
}
