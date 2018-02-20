using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FriendlyBudget.Web.Backend.Model.Application_Services.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Options;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route("api/Authentication")]
    public class AuthenticationController : Controller
    {
        [AllowAnonymous]
        [HttpPost]
        public IActionResult RequestToken([FromBody]TokenRequest request)
        {
            using (AuthenticationService service = new AuthenticationService())
            {
                bool authenticated = service.AuthenticateByEmail(request);
                if(!authenticated)
                {
                    return BadRequest("Could not authenticate user.");
                }

                throw new NotImplementedException();
            }
        }
    }
}