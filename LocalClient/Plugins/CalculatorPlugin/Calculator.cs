using FriendlyBudget.LocalClient.Components.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FriendlyBudget.LocalClient.Modules.Calculator
{
    public class Calculator
    {
        #region Fields

        readonly private FamilyMember _familyMember;
        readonly private List<FamilyMember> _familyMembersList = new List<FamilyMember>();
        readonly private List<Income> _incomes;
        readonly private List<Expenditure> _expenditures;

        #endregion

        #region Properties

        /// <summary>
        /// Incomes of a FamilyMember
        /// </summary>
        public decimal Incomes { get; set; }

        /// <summary>
        /// Incomes of whole Family
        /// </summary>
        public decimal FamilyIncomes { get; set; }

        /// <summary>
        /// Expenditures of a FamilyMember
        /// </summary>
        public decimal Expenditures { get; set; }

        /// <summary>
        /// Expenditures of whole Family
        /// </summary>
        public decimal FamilyExpenditures { get; set; }

        /// <summary>
        /// Balance of a FamilyMember
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// Balance of whole Family
        /// </summary>
        public decimal FamilyBalance { get; set; }

        /// <summary>
        /// BudgetBalance of a FamilyMember
        /// </summary>
        public decimal BudgetBalance { get; set; }

        #endregion

        #region Constructors

        public Calculator(FamilyMember familyMember)
        {
            _familyMember = familyMember;
            List<Income> incomes = new List<Income>();
            List<Expenditure> expenditures = new List<Expenditure>();
            
            foreach(Income income in familyMember.Incomes)
            {
                incomes.Add(income);
            }

            foreach(Expenditure expenditure in familyMember.Expenditures)
            {
                expenditures.Add(expenditure);
            }

            _incomes = incomes;
            _expenditures = expenditures;
        }

        public Calculator(List<FamilyMember> familyMembers)
        {
            foreach(FamilyMember familyMember in familyMembers)
            {
                _familyMembersList.Add(familyMember);
            }
        }

        public Calculator(Income income, Expenditure expenditure)
        {
            _incomes.Add(income);
            _expenditures.Add(expenditure);
        }

        public Calculator(IEnumerable<Income> incomes, IEnumerable<Expenditure> expenditures)
        {
            _incomes = incomes.ToList();
            _expenditures = expenditures.ToList();
        }

        public Calculator(decimal income, decimal expenditure)
        {
            Income newIncome = new Income();
            Expenditure newExpenditure = new Expenditure();

            newIncome.Amount = income;
            newExpenditure.Amount = expenditure;
        }

        public Calculator(IEnumerable<decimal> incomes, IEnumerable<decimal> expenditures)
        {
            foreach(decimal income in incomes)
            {
                Income newIncome = new Income();
                newIncome.Amount = income;
                _incomes.Add(newIncome);
            }

            foreach(decimal expenditure in expenditures)
            {
                Expenditure newExpenditure = new Expenditure();
                newExpenditure.Amount = expenditure;
                _expenditures.Add(newExpenditure);
            }
        }

        #endregion

        #region Public Methods

        public decimal SumIncomes()
        {
            decimal sum = 0;

            foreach(Income income in _incomes)
            {
                sum += income.Amount;
            }

            return sum;
        }

        public decimal SumFamilyIncomes()
        {
            decimal sum = 0; 

            foreach(FamilyMember familyMember in _familyMembersList)
            {
                foreach(Income income in familyMember.Incomes)
                {
                    sum += income.Amount;
                }
            }

            return sum;
        }

        public decimal SumExpenditures()
        {
            decimal sum = 0;

            foreach(Expenditure expenditure in _expenditures)
            {
                sum += expenditure.Amount;
            }

            return sum;
        }

        public decimal SumFamilyExpenditures()
        {
            decimal sum = 0;

            foreach(FamilyMember familyMember in _familyMembersList)
            {
                foreach(Expenditure expenditure in familyMember.Expenditures)
                {
                    sum += expenditure.Amount;
                }
            }

            return sum;
        }

        public decimal CalculateBalance()
        {
            decimal balance = 0;
            decimal incomeSum = 0;
            decimal expenditureSum = 0;

            foreach(Income income in _familyMember.Incomes)
            {
                incomeSum += income.Amount;
            }

            foreach(Expenditure expenditure in _familyMember.Expenditures)
            {
                expenditureSum += expenditure.Amount;
            }

            balance = incomeSum - expenditureSum;

            return balance;
        }

        public decimal CalculateFamilyBalance()
        {
            decimal balance = 0;
            decimal incomeSum = 0;
            decimal expenditureSum = 0;

            foreach(FamilyMember familyMember in _familyMembersList)
            {
                foreach(Income income in familyMember.Incomes)
                {
                    incomeSum += income.Amount;
                }

                foreach(Expenditure expenditure in familyMember.Expenditures)
                {
                    expenditureSum += expenditure.Amount;
                }
            }

            balance = incomeSum - expenditureSum;

            return balance;
        }

        public decimal CalculateBudgetBalance()
        {
            decimal budgetBalance = 0;
            decimal expenditureSum = 0;

            foreach(Expenditure expenditure in _familyMember.Expenditures)
            {
                expenditureSum += expenditure.Amount;
            }

            budgetBalance = _familyMember.BudgetSet - expenditureSum;

            return budgetBalance;
        }

        #endregion

        #region Methods



        #endregion
    }
}
