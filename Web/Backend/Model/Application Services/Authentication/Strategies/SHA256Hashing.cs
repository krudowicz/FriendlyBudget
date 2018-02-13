using FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Interfaces;
using FriendlyBudget.Web.Backend.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Strategies
{
    class SHA256Hashing : IHashingAlgorithm
    {
        public bool Validate(string password, IUser user)
        {
            throw new NotImplementedException();
        }
    }
}
