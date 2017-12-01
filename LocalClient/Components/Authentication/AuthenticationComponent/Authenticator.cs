using FriendlyBudget.LocalClient.Components.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Components.DAL.DTO;
using FriendlyBudget.LocalClient.Components.DAL.Repositories;
using System.Security.Cryptography;

namespace FriendlyBudget.LocalClient.Components.AuthenticationComponent
{
    class Authenticator : IAuthenticator<User>
    {
        private UserRepository _repository;

        public Authenticator(UserRepository repository)
        {
            _repository = repository;
        }

        public bool Authenticate(User user)
        {
            bool result = AuthenticateInternal(user);
            return result;
        }

        private bool CheckLogin(User user)
        {
            bool result = false;

            string login = user.Login;
            _repository.GetByLogin(login, out result);

            return result;
        }

        private bool CheckPassword(User user)
        {
            bool result = false;

            string login = user.Login;
            User userFromRepository = _repository.GetByLogin(login);

            if (true)
            {
                //TODO: Implement password check.
            }

            return result;
        }

        private bool AuthenticateInternal(User user)
        {
            string login = user.Login;

            User userFromRepository = _repository.GetByLogin(login);

            bool authenticated = false;

            if(CheckLogin(user))
            {
                if(CheckPassword(user))
                {
                    CheckPassword(user);
                    authenticated = true;
                }
            }

            return authenticated;
        }
    }
}
