using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.AuthenticationComponent.Helpers
{
    class PasswordComparer
    {

        public static bool ComparePasswords(string providedPassword, string userPassword)
        {
            bool result = false;

            if(string.Equals(providedPassword, userPassword))
            {
                result = true;
            }

            return result;
        }
    }
}
