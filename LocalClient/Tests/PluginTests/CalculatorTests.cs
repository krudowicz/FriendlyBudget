using System;
using NUnit.Framework;
using System.Collections.Generic;
using FriendlyBudget.LocalClient.Components.DAL.DTO;
using FriendlyBudget.LocalClient.Plugins.CalculatorPlugin;

namespace FriendlyBudget.LocalClient.Tests.PluginTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private FamilyMember familyMember;
        private List<Income> incomes;
        private List<Expenditure> expenditures;
        private Calculator calculator1;
        private Calculator calculator2;

        [SetUp]
        public void Init()
        {
            incomes = new List<Income>();
            expenditures = new List<Expenditure>();
            this.familyMember = new FamilyMember();
            this.familyMember.BudgetSet = 1000;

            decimal[] incomesArray = { 150.50M, 200, 350.20M }; //Sum == 700.70
            decimal[] expendituresArray = { 100.50M, 20, 300.20M }; //Sum == 420.70


            for (int i = 0; i < 3; i++)
            {
                Income income = new Income();
                income.Amount = incomesArray[i];
                this.incomes.Add(income);
            }

            for (int i = 0; i < 3; i++)
            {
                Expenditure expenditure = new Expenditure();
                expenditure.Amount = expendituresArray[i];
                this.expenditures.Add(expenditure);
            }

            familyMember.Incomes = incomes;
            familyMember.Expenditures = expenditures;
            calculator1 = new Calculator(this.incomes, this.expenditures);
            calculator2 = new Calculator(this.familyMember);
        }

        [TearDown]
        public void Finalize()
        {
            familyMember = null;
            incomes = null;
            expenditures = null;
            calculator1 = null;
            calculator2 = null;

        }

        [Test]
        public void Incomes_Are_Summed_Up()
        {
            decimal actual = this.calculator1.SumIncomes();
            decimal expected = 700.70M;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Expenditures_Are_Summed_Up()
        {
            decimal actual = this.calculator1.SumExpenditures();
            decimal expected = 420.70M;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Balance_Is_Calculated_Properly()
        {
            decimal actual = this.calculator2.CalculateBalance();;
            decimal expected = 280M;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BudgetBalance_Is_Calculated_Properly()
        {
            decimal actual = this.calculator2.CalculateBudgetBalance();
            decimal expected = 579.30M;

            Assert.AreEqual(expected, actual);
        }   
    }
}
