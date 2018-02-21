using FriendlyBudget.Web.Backend.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.IdentityModel.Tokens.Jwt;

namespace FriendlyBudget.Web.Backend.Model.Application_Services.Authentication
{
    public class TokenManager
    {
        public JwtSecurityToken GenerateToken(IUser user)
        {
            throw new NotImplementedException();
        }

        public bool ValidateToken(JwtSecurityToken token)
        {
            throw new NotImplementedException();
        }

        public void RevokeToken(JwtSecurityToken token)
        {
            throw new NotImplementedException();
        }
    }
}
