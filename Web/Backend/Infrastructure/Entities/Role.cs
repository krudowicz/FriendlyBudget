using FriendlyBudget.Web.Backend.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Infrastructure.Entities
{
    class Role : IRole
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public bool Read { get; set; }
        public bool Write { get; set; }
        public bool AddedAt { get; set; }
        public bool ModifiedAt { get; set; }
    }
}
