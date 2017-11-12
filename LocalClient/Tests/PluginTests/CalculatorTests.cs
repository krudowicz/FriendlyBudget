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
        private List<Income> incomes = new List<Income>();
        private List<Expenditure> expenditures = new List<Expenditure>();
        private Calculator calculator1;
        private Calculator calculator2;

        [SetUp]
        public void Init()
        {
            this.familyMember = new FamilyMember();
            this.familyMember.BudgetSet = 1000;

            double[] incomesArray = { 150.50, 200, 350.20 }; //Sum == 500.70
            double[] expendituresArray = { 100.50, 20, 300.20 }; //Sum == 420.70


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

        [Test]
        public void Incomes_Are_Summed_Up()
        {
            double actual = this.calculator1.SumIncomes();
            double expected = Math.Round(500.70, 2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Expenditures_Are_Summed_Up()
        {
            double actual = this.calculator1.SumExpenditures();
            double expected = Math.Round(420.70, 2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Balance_Is_Calculated_Properly()
        {
            double actual = this.calculator2.CalculateBalance();
            actual = Math.Round(actual, 2);
            double expected = 80;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BudgetBalance_Is_Calculated_Properly()
        {
            double actual = this.calculator2.CalculateBudgetBalance();
            double expected = Math.Round(579.30, 2);

            Assert.AreEqual(expected, actual);
        }   
    }
}
