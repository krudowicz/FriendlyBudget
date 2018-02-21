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
using FriendlyBudget.Web.Backend.Model.Interfaces;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route("api/Authentication")]
    public class AuthenticationController : Controller
    {
        [AllowAnonymous]
        [HttpPost]
        public IActionResult LogIn([FromBody]IUser user)
        {
           using (AuthenticationService service = new AuthenticationService())
           {
                bool authenticated = false;

                if (user.Username.Contains("@"))
                {
                    authenticated = service.AuthenticateByEmail(user);
                } else
                {
                    authenticated = service.AuthenticateByUsername(user);
                }

                if(!authenticated)
                {
                    return BadRequest("Wrong username/email or password provided.");
                }

                throw new NotImplementedException();
           }
        }

        
        public IActionResult LogOut(IUser user)
        {
            throw new NotImplementedException();
        }
    }
}