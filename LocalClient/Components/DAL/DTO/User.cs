﻿using FriendlyBudget.LocalClient.Components.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.DAL.DTO
{
    public class User : Person
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string PermissionLevel { get; set; } //crude prototype before I implement proper permission system
    }
}