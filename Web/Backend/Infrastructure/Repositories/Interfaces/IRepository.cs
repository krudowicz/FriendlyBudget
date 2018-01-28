using System;
using System.Collections.Generic;
using System.Text;


namespace FriendlyBudget.Web.Backend.Infrastructure.Repositories.Interfaces
{
    interface IRepository<T>
    {
        T GetOne(ulong id, out bool found);
        IList<T> GetAll();
        void Add(T item);
        void Modify(T item);
        void Delete(T item);
    }
}
