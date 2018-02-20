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

            foundUser.LastLogin = DateTime.Today.ToString();
            _repository.Modify(foundUser);

            //user.Authenticated = true;
        }

        public void AuthenticateByUsername(IUser user)
        {
            bool found = false;
            IUser foundUser = _repository.GetByUsername(user.Username, out found);

            if(!found)
            {
                return;
            }

            bool authenticated = Authenticator.Authenticate(user, foundUser, new UsernameAuthentication());

            if(!authenticated)
            {
                return;
            }

            foundUser.LastLogin = DateTime.Today.ToString();
            _repository.Modify(foundUser);
        }
    }
}
