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
    public class AuthenticationService : IDisposable
    {
        private bool _disposed = false;

        private AuthenticationContext Context { get; set; }

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

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Context = null;
                }

                _disposed = true;
            }
        }
    }
}
