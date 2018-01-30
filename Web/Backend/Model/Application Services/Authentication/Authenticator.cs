using FriendlyBudget.Web.Backend.Infrastructure.Database;
using FriendlyBudget.Web.Backend.Infrastructure.DTO;
using FriendlyBudget.Web.Backend.Infrastructure.Entities;
using FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Interfaces;
using FriendlyBudget.Web.Backend.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Model.Application_Services.Authentication
{
    public static class Authenticator
    {
        public static bool Authenticate(IUser user, IAuthenticate authentication)
        {
            throw new NotImplementedException();
            return authentication.Authenticate(user);
        }
    }
}
