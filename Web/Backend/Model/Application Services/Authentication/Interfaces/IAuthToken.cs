using FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Interfaces
{
    public interface IAuthToken
    {
        bool IsValid { get; }
        bool Validate(IAuthToken token, IEncryption validation);
    }
}