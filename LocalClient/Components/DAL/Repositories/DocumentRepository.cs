using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Components.DAL.DTO;
using FriendlyBudget.LocalClient.Core.Interfaces;

namespace FriendlyBudget.LocalClient.Components.DAL.Repositories
{
    class DocumentRepository : IRepository<Document>
    {
        public IEnumerable<Document> Items { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(Document item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Document> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Document> GetByQuery(string query)
        {
            throw new NotImplementedException();
        }

        public Document GetOne(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Document item)
        {
            throw new NotImplementedException();
        }

        public void Update(Document oldItem, Document newItem)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<Document> oldItems, IEnumerable<Document> newItems)
        {
            throw new NotImplementedException();
        }
    }
}
