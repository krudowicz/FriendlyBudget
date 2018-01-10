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
        public decimal TotalIncome { get; private set; }
        public decimal TotalExpenditure { get; private set; }
        public decimal TotalSavings { get; private set; }

        #endregion

        #region Constructors

        public FamilyMember()
        {

        }

        #endregion

        #region Methods

        private decimal CalculateBudgetBalance()
        {
            return BudgetSet - TotalExpenditure;
        }

        private decimal CalculateBalance()
        {
            return TotalIncome - TotalExpenditure;
        }

        private decimal CalculateTotalIncome()
        {
            decimal total = 0;

            foreach(Income income in Incomes)
            {
                total += income.Amount;
            }

            return total;
        }

        private decimal CalculateTotalExpenditures()
        {
            decimal total = 0;

            foreach(Expenditure expenditure in Expenditures)
            {
                total += expenditure.Amount;
            }

            return total;
        }

        private decimal CalculateTotalSavings()
        {
            decimal total = 0;

            foreach(Saving saving in Savings)
            {
                total += saving.MoneyAmountCurrent;
            }

            return total;
        }

        private decimal CalculateTotalSavingsRequired()
        {
            decimal total = 0;

            foreach(Saving saving in Savings)
            {
                total += saving.MoneyAmountRequired;
            }

            return total;
        }

        #endregion
    }
}
