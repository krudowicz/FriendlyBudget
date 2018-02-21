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
using FriendlyBudget.Web.Backend.Infrastructure.DTO;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route("api/Authentication")]
    public class AuthenticationController : Controller
    {
        [AllowAnonymous]
        [HttpPost]
        public IActionResult LogIn([FromBody]UserDto user)
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


                TokenManager manager = new TokenManager();
                JwtSecurityToken token = manager.GenerateToken(user);
                user.Token = token.ToString(); //That will definitely not work.

                throw new NotImplementedException();
           }
        }

        
        public IActionResult LogOut(UserDto user)
        {
            TokenManager manager = new TokenManager();

            JwtSecurityToken token = new JwtSecurityToken(user.Token);

            manager.RevokeToken(token);

            throw new NotImplementedException();
        }
    }
}