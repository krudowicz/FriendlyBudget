using FriendlyBudget.Web.Backend.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Interfaces
{
    interface IHashingAlgorithm
    {
        bool Validate(IUser user, IUser foundUser);
    }
}
