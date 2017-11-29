using FriendlyBudget.LocalClient.Components.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.AuthenticationComponent
{
    class Authenticator<T> : IAuthenticator<T>
    {

        public bool Authenticate(T user)
        {
            bool result = AuthenticateInternal(user);
            return result;
        }

        private bool CheckLogin(string login)
        {
            throw new NotImplementedException();
        }

        private bool CheckPassword(T user)
        {
            throw new NotImplementedException();
        }

        private bool AuthenticateInternal(T user)
        {
            bool authenticated = false;
            throw new NotImplementedException();
        }
    }
}
