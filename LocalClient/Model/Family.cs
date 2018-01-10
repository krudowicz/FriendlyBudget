using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.DomainModel
{
    class Family
    {
        #region Properties

        public List<FamilyMember> FamilyMembers { get; private set; }
        public decimal TotalIncome
        {
            get { return CalculateTotalIncome(); }
        }

        public decimal TotalExpenditure
        {
            get { return CalculateTotalExpenditure(); }
        }

        public decimal Budget { get; private set; }
        public decimal BudgetBalance
        {
            get { return CalculateBudgetBalance(); }
        }

        public decimal Balance
        {
            get => TotalIncome - TotalExpenditure;
        }

        #endregion

        #region Constructors

        #endregion

        #region Methods

        private decimal CalculateTotalIncome()
        {
            decimal total = 0;

            foreach(FamilyMember familyMember in FamilyMembers)
            {
                total += familyMember.TotalIncome;
            }

            return total;
        }

        private decimal CalculateTotalExpenditure()
        {
            decimal total = 0;

            foreach(FamilyMember familyMember in FamilyMembers)
            {
                total += familyMember.TotalExpenditure;
            }

            return total;
        }

        private decimal CalculateBudgetBalance()
        {
            return Budget - TotalExpenditure;
        }

        #endregion
    }
}
