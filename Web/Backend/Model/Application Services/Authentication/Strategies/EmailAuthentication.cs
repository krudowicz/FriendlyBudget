using FriendlyBudget.Web.Backend.Infrastructure.DTO;
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

        public bool Authenticate(IUser user)
        {
            bool result = false;



            return result;
        }
    }
}
