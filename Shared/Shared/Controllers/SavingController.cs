using FriendlyBudget.Shared.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FriendlyBudget.Shared.Controllers
{
    public class SavingController : ApiController
    {
        // GET: api/Saving
        public IEnumerable<Saving> Get()
        {
            throw new NotImplementedException();
        }

        // GET: api/Saving/5
        public Saving Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Saving
        public void Post([FromBody]Saving value)
        {
        }

        // PUT: api/Saving/5
        public void Put(int id, [FromBody]Saving value)
        {
        }

        // DELETE: api/Saving/5
        public void Delete(int id)
        {
        }
    }
}
