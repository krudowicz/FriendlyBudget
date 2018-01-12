using FriendlyBudget.Shared.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FriendlyBudget.Shared.Controllers
{
    public class FamilyController : ApiController
    {
        // GET: api/Family
        public IEnumerable<Family> Get()
        {
            throw new NotImplementedException();
        }

        // GET: api/Family/5
        public Family Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Family
        public void Post([FromBody]Family value)
        {
        }

        // PUT: api/Family/5
        public void Put(int id, [FromBody]Family value)
        {
        }

        // DELETE: api/Family/5
        public void Delete(int id)
        {
        }
    }
}
