using FriendlyBudget.LocalClient.Components.Core.Interfaces;
using FriendlyBudget.LocalClient.Components.DAL.DTO;
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

            IRepository<User> userRepository = new UserRepository();


            return result;
        }
    }
}
