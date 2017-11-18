using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Components.DAL.DTO;
using FriendlyBudget.LocalClient.Components.Core.Interfaces;

namespace FriendlyBudget.LocalClient.Components.DAL.Repositories
{
    /// <summary>
    /// DocumentRepository, not used at the moment, but will be in the future with Documents implementation.
    /// SHOULD NOT BE USED RIGHT NOW!
    /// </summary>
    class DocumentRepository : IRepository<Document>
    {
        public List<Document> Items { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

        public Document GetOne(ulong id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Document item)
        {
            throw new NotImplementedException();
        }

        public void Update(Document modifiedItem)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<Document> modifiedItems)
        {
            throw new NotImplementedException();
        }
    }
}
