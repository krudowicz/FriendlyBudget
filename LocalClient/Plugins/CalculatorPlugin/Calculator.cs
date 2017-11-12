using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Components.DAL.DTO;


namespace FriendlyBudget.LocalClient.Plugins.CalculatorPlugin
{
    public class Calculator
    {
        #region Fields

        readonly private FamilyMember _familyMember;
        readonly private List<FamilyMember> _familyMembersList;
        readonly private List<Income> _incomes;
        readonly private List<Expenditure> _expenditures;

        #endregion

        #region Properties

        public decimal Incomes { get; set; }
        public decimal Expenditures { get; set; }
        public decimal Balance { get; set; }
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

        public decimal SumAllIncomes()
        {
            throw new NotImplementedException();
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

        public decimal SumAllExpenditures()
        {
            throw new NotImplementedException();
        }

        public decimal CalculateBalance()
        {
            decimal balance = 0;

            foreach(Income income in _familyMember.Incomes)
            {
                balance += income.Amount;
            }

            foreach(Expenditure expenditure in _familyMember.Expenditures)
            {
                balance -= expenditure.Amount;
            }



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
