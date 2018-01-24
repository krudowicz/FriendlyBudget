using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Infrastructure.Entities
{
    class Family
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public List<FamilyMember> FamilyMembers { get; set; }
        public Location Location { get; set; }
        public string AddedAt { get; set; }
        public string ModifiedAt { get; set; }
    }
}
