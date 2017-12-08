using FriendlyBudget.LocalClient.Components.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Components.DAL.DTO;
using FriendlyBudget.LocalClient.Components.DAL.Repositories;
using FriendlyBudget.LocalClient.Components.AuthenticationComponent.Helpers;

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

        //TODO: It is probably bugged and needs different solution to allow comparing passwords
        private bool CheckPassword(User user)
        {
            bool result = false;

            string login = user.Login;
            User userFromRepository = _repository.GetByLogin(login);

            var providedPassword = PasswordEncoder.Encode(user.Password);
            var actualPassword = userFromRepository.Password;

            bool passwordsMatch = providedPassword == actualPassword;

            if (passwordsMatch)
            {
                result = true;
            }

            return result;
        }

        private bool AuthenticateInternal(User user)
        {
            string login = user.Login;

            User userFromRepository = _repository.GetByLogin(login, out bool userFound);

            bool authenticated = false;

            if(userFound)
            {
                bool passwordMatches = CheckPassword(user);

                if(passwordMatches)
                {
                    authenticated = true;
                }
            }

            return authenticated;
        }
    }
}
