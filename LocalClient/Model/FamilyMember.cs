using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.DomainModel
{
    class FamilyMember
    {
        #region Fields

        #endregion

        #region Properties

        public List<Income> Incomes { get; set; }
        public List<Expenditure> Expenditures { get; set; }
        public List<Saving> Savings { get; set; }
        public decimal BudgetSet { get; set; }
        public decimal BudgetBalance { get; private set; }
        public decimal Balance { get; private set; }
        public decimal OverallIncome { get; private set; }
        public decimal OverallExpenditure { get; private set; }
        public decimal OverallSavings { get; private set; }

        #endregion

        #region Constructors

        public FamilyMember()
        {

        }

        #endregion

        #region Methods

        private decimal CalculateBudgetBalance()
        {
            throw new NotImplementedException();
        }

        private decimal CalculateBalance()
        {
            throw new NotImplementedException();
        }

        private decimal CalculateOverallIncome()
        {
            throw new NotImplementedException();
        }

        private decimal CalculateOverallExpenditures()
        {
            throw new NotImplementedException();
        }

        private decimal CalculateOverallSavings()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
