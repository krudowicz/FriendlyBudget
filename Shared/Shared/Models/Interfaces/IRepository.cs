using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.Shared.Models.Interfaces
{
    interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        void Add(T item);
        void Update(T item);
        void Delete(T item);
    }
}
