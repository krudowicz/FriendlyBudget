using FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Interfaces;
using FriendlyBudget.Web.Backend.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Strategies
{
    class SHA256Hashing : IHashingAlgorithm
    {
        public bool Validate(IUser user, IUser foundUser)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            SHA256CryptoServiceProvider hashingAlgorithm = new SHA256CryptoServiceProvider();

            byte[] providedPassword = encoding.GetBytes(user.Password);

            byte[] providedPasswordHash = hashingAlgorithm.ComputeHash(providedPassword);
            byte[] actualPassword = Convert.FromBase64String(foundUser.Password);

            for(int i = 0; i < providedPasswordHash.Length; i++)
            {
                if(providedPasswordHash != actualPassword)
                {
                    throw new UnauthorizedAccessException();
                }
            }

            return true;
        }
    }
}
