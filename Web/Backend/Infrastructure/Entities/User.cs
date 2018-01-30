using FriendlyBudget.Web.Backend.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Infrastructure.Entities
{
    class User : IUser
    {
        public ulong Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IRole Role { get; set; }
        public string AddedAt { get; set; }
        public string ModifiedAt { get; set; }
    }
}
