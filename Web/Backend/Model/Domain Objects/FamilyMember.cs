using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Model.Domain_Objects
{
    class FamilyMember
    {
        public ulong Id { get; private set; }
        public ulong Name { get; private set; }
        public Family Family { get; set; }
        public IEnumerable<Income> Incomes { get; private set; }
        public IEnumerable<Expenditure> Expenditures { get; private set; }
        public IEnumerable<Saving> Savings { get; private set; }
    }
}
