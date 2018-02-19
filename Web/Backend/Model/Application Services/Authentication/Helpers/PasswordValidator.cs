using FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Interfaces;
using FriendlyBudget.Web.Backend.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Helpers
{
    class PasswordValidator
    {
        public static bool Validate(IUser user, IUser foundUser, IHashingAlgorithm usedAlgorithm)
        {
            return usedAlgorithm.Validate(user, foundUser);
        }
    }
}
