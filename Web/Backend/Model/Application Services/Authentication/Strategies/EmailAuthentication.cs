using FriendlyBudget.Web.Backend.Infrastructure.DTO;
using FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Helpers;
using FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Interfaces;
using FriendlyBudget.Web.Backend.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Strategies
{
    public class EmailAuthentication : IAuthenticate
    {
        public EmailAuthentication()
        {

        }

        public bool Authenticate(IUser user, IUser foundUser)
        {
            bool result = false;

            if(foundUser != null && user.Email == foundUser.Email)
            {
                return PasswordValidator.Validate(user, foundUser, new BCryptHashing());
            }

            return result;
        }
    }
}
