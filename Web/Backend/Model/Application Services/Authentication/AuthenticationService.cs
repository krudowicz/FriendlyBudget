using FriendlyBudget.Web.Backend.Infrastructure.Repositories;
using FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Strategies;
using FriendlyBudget.Web.Backend.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Model.Application_Services.Authentication
{
    class AuthenticationService
    {
        private UserRepository _repository;

        public AuthenticationService(UserRepository repository)
        {
            _repository = repository;
        }

        public void AuthenticateByEmail(IUser user)
        {
            bool found = false;
            IUser foundUser = _repository.GetByEmail(user.Username, out found);

            if(!found)
            {
                return;
            }

            bool authenticated = Authenticator.Authenticate(user, foundUser, new EmailAuthentication());

            if(!authenticated)
            {
                return;
            }

            //user.Token = TokenGenerator.Generate();
        }

        public void AuthenticateByUsername(IUser user)
        {
            throw new NotImplementedException();
        }

        public bool CheckToken(IUser user)
        {
            throw new NotImplementedException();

            //Future code
            /* bool authenticated = false;
             * string token = user.Token;
             * 
             * if(token == null || token == string.Empty) {
             *     return authenticated;
             * }
             * 
             * bool valid = CheckValidity(token);
             * 
             * if(!valid) {
             *     return authenticated;
             * }
             * 
             * valid = true;
             * return valid;
             */
        }
    }
}
