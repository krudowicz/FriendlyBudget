using FriendlyBudget.Web.Backend.Infrastructure.Database;
using FriendlyBudget.Web.Backend.Infrastructure.DTO;
using FriendlyBudget.Web.Backend.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Model.Application_Services.Authentication
{
    class Authenticator
    {
        public static bool Authenticate(UserDto userDto)
        {
            bool result = false;

            //It is only a mockup. The database operation will be extracted.
            using (var context = new MainContext())
            {
                User user = context.Users.Find(userDto.Id);

                if(user != null)
                {
                    if(userDto.Email == user.Email)
                    {
                        result = true;
                    }
                }
            }

            return result;
        }
    }
}
