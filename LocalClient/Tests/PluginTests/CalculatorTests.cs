using System;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;
using FriendlyBudget.LocalClient.Components.DAL.DTO;
using FriendlyBudget.LocalClient.Plugins.CalculatorPlugin;

namespace FriendlyBudget.LocalClient.Tests.PluginTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private List<FamilyMember> familyMembers;
        private List<Income> incomes;
        private List<Expenditure> expenditures;
        private Calculator calculator1;
        private Calculator calculator2;
        private Calculator calculator3;

        [SetUp]
        public void Init()
        {
            familyMembers = new List<FamilyMember>();
            incomes = new List<Income>();
            expenditures = new List<Expenditure>();

            decimal[] incomesArray = { 150.50M, 200, 350.20M }; //Sum == 700.70
            decimal[] expendituresArray = { 100.50M, 20, 300.20M }; //Sum == 420.70

            for (int i = 0; i < 3; i++)
            {
                Income income = new Income();
                income.Amount = incomesArray[i];
                incomes.Add(income);
            }

            for (int i = 0; i < 3; i++)
            {
                Expenditure expenditure = new Expenditure();
                expenditure.Amount = expendituresArray[i];
                expenditures.Add(expenditure);
            }

            for (int i = 0; i < 3; i++)
            {
                FamilyMember familyMember = new FamilyMember();
                familyMembers.Add(familyMember);
                familyMembers.ElementAt(i).Incomes = incomes;
                familyMembers.ElementAt(i).Expenditures = expenditures;
                familyMembers.ElementAt(i).BudgetSet = 1000;
            }

            calculator1 = new Calculator(incomes, expenditures);
            calculator2 = new Calculator(familyMembers.ElementAt(0));
            calculator3 = new Calculator(familyMembers);
        }

        [TearDown]
        public void CleanUp()
        {
            familyMembers = null;
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
        
        [Test]
        public void Family_Incomes_Are_Summed_Up()
        {
            decimal actual = calculator3.SumFamilyIncomes();
            decimal expected = 2102.10M;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Family_Expenditures_Are_Summed_Up()
        {
            decimal actual = calculator3.SumFamilyExpenditures();
            decimal expected = 1262.10M;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Family_Balance_Is_Calculated_Properly()
        {
            decimal actual = calculator3.CalculateFamilyBalance();
            decimal expected = 840M;

            Assert.AreEqual(expected, actual);
        }
    }
}
