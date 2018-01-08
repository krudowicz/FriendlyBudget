using FriendlyBudget.LocalClient.Components.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Components.AuthenticationComponent.Helpers;
using FriendlyBudget.LocalClient.Components.Core.DTO;

namespace FriendlyBudget.LocalClient.Components.AuthenticationComponent
{
    public class Authenticator : IAuthenticator<User>
    {
        public Authenticator()
        {

        }

        public bool Authenticate(string password, User user)
        {
            bool result = AuthenticateInternal(password, user);
            return result;
        }

        //TODO: It is probably bugged and needs different solution to allow comparing passwords
        private bool CheckPassword(string providedPassword, string userPassword)
        {
            bool result = false;

            

            return result;
        }

        private bool AuthenticateInternal(string password, User user)
        {
            bool result = false;

            return result;
        }
    }
}
