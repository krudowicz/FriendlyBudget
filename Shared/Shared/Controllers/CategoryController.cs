using FriendlyBudget.Shared.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FriendlyBudget.Shared.Controllers
{
    public class CategoryController : ApiController
    {
        // GET: api/Category
        public IEnumerable<Category> Get()
        {
            throw new NotImplementedException();
        }

        // GET: api/Category/5
        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Category
        public void Post([FromBody]Category value)
        {
        }

        // PUT: api/Category/5
        public void Put(int id, [FromBody]Category value)
        {
        }

        // DELETE: api/Category/5
        public void Delete(int id)
        {
        }
    }
}
