using System;
using System.Collections.Generic;
using System.Text;
using BCrypt;
using FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Interfaces;
using FriendlyBudget.Web.Backend.Model.Interfaces;

namespace FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Strategies
{
    class BCryptHashing : IHashingAlgorithm
    {
        public bool Validate(IUser user, IUser foundUser)
        {
            return BCryptHelper.CheckPassword(user.Password, foundUser.Password);
        }
    }
}
