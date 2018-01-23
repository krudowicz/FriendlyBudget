using FriendlyBudget.Web.Backend.Model.Value_Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Model.Domain_Objects
{
    class Family
    {
        private ulong Id { get; set; }
        private string Name { get; set; }
        private IEnumerable<FamilyMember> FamilyMembers { get; set; }

        public Family()
        {
            
        }

        public Money CalculateBalance()
        {
            throw new NotImplementedException();
        }

        public Money CalculateIncome()
        {
            throw new NotImplementedException();
        }

        public Money CalculateExpenditure()
        {
            throw new NotImplementedException();
        }

        public Money CalculateAverageIncome()
        {
            throw new NotImplementedException();
        }

        public Money CalculateAverageExpenditure()
        {
            throw new NotImplementedException();
        }
    }
}
