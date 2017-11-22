using System;
using System.Collections.Generic;
using FriendlyBudget.LocalClient.Components.Validation;
using FriendlyBudget.LocalClient.Components.DAL.DTO;
using FriendlyBudget.LocalClient.Components.Core.Abstraction;
using NUnit.Framework;

namespace FriendlyBudget.LocalClient.Tests.ComponentTests
{
    [TestFixture]
    class ValidatorTests
    {
        private Validator<DataObject> _validator;
        private FamilyMember _familyMember;
        private Income _income;
        private Expenditure _expenditure;
        private Category _incomeCategory;
        private Category _expenditureCategory;

        [SetUp]
        public void SetUp()
        {
            _validator = new Validator<DataObject>();
            _familyMember = new FamilyMember();
            _income = new Income();
            _expenditure = new Expenditure();
            _incomeCategory = new Category();
            _expenditureCategory = new Category();

            _familyMember.FirstName = "Adam";

            _expenditureCategory.Name = "Jedzenie";
            _incomeCategory.Name = "";

            _income.Name = "Wyplata";
            _income.Amount = 1500M;
            _income.Category = _incomeCategory;
            _income.Person = _familyMember;
            _income.Constant = true;
            _income.Date = DateTime.Today.Date;

            _expenditure.Name = "Bulka";
            _expenditure.Amount = 0.8M;
            _expenditure.Category = _expenditureCategory;
            _expenditure.Person = _familyMember;
            _expenditure.Constant = false;
        } 

        [TearDown]
        public void Cleanup()
        {
            _validator = null;
            _familyMember = null;
            _income = null;
            _expenditure = null;
            _incomeCategory = null;
            _expenditureCategory = null;
        }

        [Test]
        public void FamilyMember_Is_Valid()
        {
            FamilyMember familyMember = _familyMember;
            Dictionary<string, string> ruleSet = new Dictionary<string, string>();
            ruleSet.Add("name", "required");

            bool expected = true;
            bool actual = _validator.Validate(ruleSet, familyMember);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Income_Is_Valid()
        {
            Income income = _income;
            Dictionary<string, string> ruleSet = new Dictionary<string, string>();
            ruleSet.Add("name", "required");
            ruleSet.Add("amount", "required");
            ruleSet.Add("category", "required");
            ruleSet.Add("person", "required");
            ruleSet.Add("date", "required");

            bool expected = true;
            bool actual = _validator.Validate(ruleSet, income);


            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Expenditure_Is_Invalid()
        {
            Expenditure expenditure = _expenditure;
            Dictionary<string, string> ruleSet = new Dictionary<string, string>();
            ruleSet.Add("name", "required");
            ruleSet.Add("amount", "required");
            ruleSet.Add("category", "required");
            ruleSet.Add("person", "required");
            ruleSet.Add("date", "required");

            bool expected = false;
            bool actual = _validator.Validate(ruleSet, expenditure);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Category_Is_Valid()
        {
            Category category = _expenditureCategory;
            Dictionary<string, string> ruleSet = new Dictionary<string, string>();
            ruleSet.Add("name", "required");

            bool expected = true;
            bool actual = _validator.Validate(ruleSet, category);


            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Category_Is_Invalid()
        {
            Category category = _incomeCategory;
            Dictionary<string, string> ruleSet = new Dictionary<string, string>();
            ruleSet.Add("name", "required");

            bool expected = false;
            bool actual = _validator.Validate(ruleSet, category);

            Assert.AreEqual(expected, actual);
        }


    }
}
