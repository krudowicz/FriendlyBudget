using FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Strategies
{
    class SHA512Validation : ITokenValidation
    {
        public bool Validate(IAuthToken token)
        {
            throw new NotImplementedException();
        }
    }
}
