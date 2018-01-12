using FriendlyBudget.Shared.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FriendlyBudget.Shared.Controllers
{
    public class IncomeController : ApiController
    {
        // GET: api/Income
        public IEnumerable<Income> Get()
        {
            throw new NotImplementedException();
        }

        // GET: api/Income/5
        public Income Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Income
        public void Post([FromBody]Income value)
        {
        }

        // PUT: api/Income/5
        public void Put(int id, [FromBody]Income value)
        {
        }

        // DELETE: api/Income/5
        public void Delete(int id)
        {
        }
    }
}
