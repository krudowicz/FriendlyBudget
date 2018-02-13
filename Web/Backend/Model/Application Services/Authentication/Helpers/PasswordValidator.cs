using FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Interfaces;
using FriendlyBudget.Web.Backend.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Helpers
{
    class PasswordValidator
    {
        public bool Validate(string password, IUser user, IHashingAlgorithm usedAlgorithm)
        {
            return usedAlgorithm.Validate(password, user);
        }
    }
}
