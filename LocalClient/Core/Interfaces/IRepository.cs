using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.Core.Interfaces
{
    public interface IRepository<T>
    {
        List<T> Items { get; set; }

        IEnumerable<T> GetAll();
        IEnumerable<T> GetByQuery(string query);
        T GetOne(long id);
        void Add(T item);
        void Update(T modifiedItem);
        void Update(IEnumerable<T> modifiedItems);
        void Remove(T item);
    }
}
