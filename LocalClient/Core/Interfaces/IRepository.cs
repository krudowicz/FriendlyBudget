using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Core.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> Items { get; set; }

        IEnumerable<T> GetAll();
        IEnumerable<T> GetByQuery(string query);
        T GetOne(long id);
        void Add(T item);
        void Update(T oldItem, T newItem);
        void Update(IEnumerable<T> oldItems, IEnumerable<T> newItems);
        void Remove(T item);
    }
}
