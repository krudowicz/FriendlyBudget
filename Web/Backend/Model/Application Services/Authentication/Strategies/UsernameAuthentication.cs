using FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Interfaces;
using FriendlyBudget.Web.Backend.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Strategies
{
    class UsernameAuthentication : IAuthenticate
    {
        public UsernameAuthentication()
        {

        }

        public bool Authenticate(IUser user, IUser foundUser)
        {
            throw new NotImplementedException();
        }
    }
}
