using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Components.DAL.Entities;
using FriendlyBudget.LocalClient.Components.DAL.Database;
using FriendlyBudget.LocalClient.Components.Core.Interfaces;

namespace FriendlyBudget.LocalClient.Components.DAL.Repositories
{
    class CategoryRepository : IRepository<Category>
    {
        #region Fields

        private List<Category> _items;

        #endregion

        #region Properties

        public List<Category> Items
        {
            get { return _items; }
            set => _items = value;
        }

        #endregion

        #region Public Methods

        public void Add(Category item)
        {
            using (var context = new MainContext())
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
        }

        public IEnumerable<Category> GetAll()
        {
            using (var context = new MainContext())
            {
                IEnumerable<Category> Categories = context.Categories.AsEnumerable();
                UpdateItemsList(Categories);
                return Categories;
            }
        }

        public IEnumerable<Category> GetByQuery(string query)
        {
            using (var context = new MainContext())
            {
                IEnumerable<Category> Categories = context.Categories.SqlQuery(query);
                UpdateItemsList(Categories);
                return Categories;
            }
        }

        public Category GetOne(ulong id)
        {
            using (var context = new MainContext())
            {
                Category Category;
                var query = (from c in context.Categories
                             where c.Id == id
                             select c);

                Category = query.FirstOrDefault();

                UpdateItemsList(Category);

                return Category;
            }
        }

        public void Remove(Category item)
        {
            using (var context = new MainContext())
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(Category modifiedItem)
        {
            using (var context = new MainContext())
            {
                context.Entry(modifiedItem).State = System.Data.Entity.EntityState.Modified;
                UpdateItemsList(modifiedItem);
                context.SaveChanges();
            }
        }

        public void Update(IEnumerable<Category> modifiedItems)
        {
            using (var context = new MainContext())
            {
                foreach (Category modifiedItem in modifiedItems)
                {
                    context.Entry(modifiedItem).State = System.Data.Entity.EntityState.Modified;
                }

                UpdateItemsList(modifiedItems);
                context.SaveChanges();
            }
        }

        #endregion

        #region Methods

        private void UpdateItemsList(Category item)
        {
            Items.Clear();
            Items.Add(item);
        }

        private void UpdateItemsList(IEnumerable<Category> items)
        {
            Items = items.ToList();
        }

        #endregion
    }
}
