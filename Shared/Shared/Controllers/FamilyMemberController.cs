using FriendlyBudget.Shared.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FriendlyBudget.Shared.Controllers
{
    public class FamilyMemberController : ApiController
    {
        // GET: api/FamilyMember
        public IEnumerable<FamilyMember> Get()
        {
            throw new NotImplementedException();
        }

        // GET: api/FamilyMember/5
        public FamilyMember Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/FamilyMember
        public void Post([FromBody]FamilyMember value)
        {
        }

        // PUT: api/FamilyMember/5
        public void Put(int id, [FromBody]FamilyMember value)
        {
        }

        // DELETE: api/FamilyMember/5
        public void Delete(int id)
        {
        }
    }
}
