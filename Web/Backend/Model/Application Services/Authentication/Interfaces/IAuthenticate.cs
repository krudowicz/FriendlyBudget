using FriendlyBudget.Web.Backend.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Interfaces
{
    public interface IAuthenticate
    {
        bool Authenticate(UserDto user);
    }
}
