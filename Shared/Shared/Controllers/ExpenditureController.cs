using FriendlyBudget.Shared.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FriendlyBudget.Shared.Controllers
{
    public class ExpenditureController : ApiController
    {
        // GET: api/Expenditure
        public IEnumerable<Expenditure> Get()
        {
            throw new NotImplementedException();
        }

        // GET: api/Expenditure/5
        public Expenditure Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Expenditure
        public void Post([FromBody]Expenditure value)
        {
        }

        // PUT: api/Expenditure/5
        public void Put(int id, [FromBody]Expenditure value)
        {
        }

        // DELETE: api/Expenditure/5
        public void Delete(int id)
        {
        }
    }
}
