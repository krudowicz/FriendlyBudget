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
        private IEncryption hashAlgorithm;

        public bool IsValid { get => Validate(this, hashAlgorithm); }

        public AuthToken(IUser user, IEncryption algorithm)
        {
            this.hashAlgorithm = algorithm;
        }

        public bool Validate(IAuthToken token, IEncryption validation)
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