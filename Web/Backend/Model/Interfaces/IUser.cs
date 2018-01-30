using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Model.Interfaces
{
    interface IUser
    {
        ulong Id { get; set; }
        string Username { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        IRole Role { get; set; }
    }
}
