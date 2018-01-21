using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Model.Domain_Objects
{
    class Family
    {
        public ulong Id { get; private set; }
        public IEnumerable<FamilyMember> FamilyMembers { get; private set; }
    }
}
