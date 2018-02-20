using FriendlyBudget.Web.Backend.Infrastructure.Database;
using FriendlyBudget.Web.Backend.Infrastructure.Repositories;
using FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Strategies;
using FriendlyBudget.Web.Backend.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace FriendlyBudget.Web.Backend.Model.Application_Services.Authentication
{
    class AuthenticationService
    {
        private AuthenticationContext Context { get; }

        public AuthenticationService()
        {
            Context = new AuthenticationContext();
        }

        public bool AuthenticateByEmail(IUser user)
        {
            bool found = false;

            using (UserRepository repository = new UserRepository(Context))
            {
                IUser foundUser = repository.GetByEmail(user.Username, out found);

                if (!found)
                {
                    return false;
                }

                bool authenticated = Authenticator.Authenticate(user, foundUser, new EmailAuthentication());

                if (!authenticated)
                {
                    return false;
                }

                foundUser.LastLogin = DateTime.Today.ToString();
                repository.Modify(foundUser);

                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, user.Username)
                };

                return true;
            }
        }

        public bool AuthenticateByUsername(IUser user)
        {
            bool found = false;

            using (UserRepository repository = new UserRepository(Context))
            {
                IUser foundUser = repository.GetByUsername(user.Username, out found);

                if (!found)
                {
                    return false;
                }

                bool authenticated = Authenticator.Authenticate(user, foundUser, new UsernameAuthentication());

                if (!authenticated)
                {
                    return false;
                }

                foundUser.LastLogin = DateTime.Today.ToString();
                repository.Modify(foundUser);

                return true;
            }
        }
    }
}
