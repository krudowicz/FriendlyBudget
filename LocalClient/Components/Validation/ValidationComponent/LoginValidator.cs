using FriendlyBudget.LocalClient.Components.Core.Interfaces;
using FriendlyBudget.LocalClient.Components.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.Validation
{
    public class LoginValidator
    {
        public static bool CheckUserExistence(string login)
        {
            bool result = false;

            UserRepository userRepository = new UserRepository();

            bool found = false;
            userRepository.GetByLogin(login, out found);

            result = found;

            return result;
        }
    }
}
