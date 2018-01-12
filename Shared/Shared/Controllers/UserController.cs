using FriendlyBudget.Shared.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FriendlyBudget.Shared.Controllers
{
    public class UserController : ApiController
    {
        // GET: api/User
        public IEnumerable<User> Get()
        {
            throw new NotImplementedException();
        }

        // GET: api/User/5
        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/User
        public void Post([FromBody]User value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]User value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
