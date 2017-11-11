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
    class IncomeRepository : IRepository<Income>
    {
        private List<Income> _items;

        public List<Income> Items
        {
            get { return _items; }
            set => _items = value;
        }

        public void Add(Income item)
        {
            using(var context = new MainContext())
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
        }

        public IEnumerable<Income> GetAll()
        {
            using(var context = new MainContext())
            {
                IEnumerable<Income> incomes = context.Incomes.AsEnumerable();
                UpdateItemsList(incomes);
                return incomes;
            }
        }

        public IEnumerable<Income> GetByQuery(string query)
        {
            using(var context = new MainContext())
            {
                IEnumerable<Income> incomes = context.Incomes.SqlQuery(query);
                UpdateItemsList(incomes);
                return incomes;
            }
        }

        public Income GetOne(long id)
        {
            using(var context = new MainContext())
            {
                Income income;
                var query = (from c in context.Incomes
                             where c.Id == id
                             select c);

                income = query.FirstOrDefault();

                UpdateItemsList(income);

                return income;
            }
        }

        public void Remove(Income item)
        {
            using(var context = new MainContext())
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(Income modifiedItem)
        {
            using(var context = new MainContext())
            {
                context.Entry(modifiedItem).State = System.Data.Entity.EntityState.Modified;
                UpdateItemsList(modifiedItem);
                context.SaveChanges();
            }
        }

        public void Update(IEnumerable<Income> modifiedItems)
        {
            using(var context = new MainContext())
            {
                foreach(Income modifiedItem in modifiedItems)
                {
                    context.Entry(modifiedItem).State = System.Data.Entity.EntityState.Modified;
                }

                UpdateItemsList(modifiedItems);
                context.SaveChanges();
            }
        }

        private void UpdateItemsList(Income item)
        {
            Items.Clear();
            Items.Add(item);
        }

        private void UpdateItemsList(IEnumerable<Income> items)
        {
            Items.Clear();
            Items = items.ToList();
        }
    }
}
