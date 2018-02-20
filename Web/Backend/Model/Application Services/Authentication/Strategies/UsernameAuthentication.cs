using FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Helpers;
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
            bool result = false;

            if(user != null && user.Username == foundUser.Username)
            {
                return PasswordValidator.Validate(user, foundUser, new BCryptHashing());
            }

            return result;
        }
    }
}
