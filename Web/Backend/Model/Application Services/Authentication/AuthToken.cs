using FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Enums;
using FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Interfaces;
using FriendlyBudget.Web.Backend.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace FriendlyBudget.Web.Backend.Model.Application_Services.Authentication 
{
    public class AuthToken : IAuthToken
    {
        private ITokenValidation hashAlgorithm;

        public bool IsValid { get => Validate(this, hashAlgorithm); }

        public AuthToken(IUser user, ITokenValidation algorithm)
        {
            this.hashAlgorithm = algorithm;
        }

        public bool Validate(IAuthToken token, ITokenValidation validation)
        {
            bool valid = false;

            if(validation.Validate(token))
            {
                valid = true;
            }

            return valid;
        }
    }
}