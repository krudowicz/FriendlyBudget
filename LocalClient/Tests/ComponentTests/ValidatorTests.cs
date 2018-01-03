using System;
using System.Collections.Generic;
using FriendlyBudget.LocalClient.Components.Validation;
using FriendlyBudget.LocalClient.Components.Core.Abstraction;
using NUnit.Framework;
using FriendlyBudget.LocalClient.Components.Core.DTO;

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
        public void Init()
        {
            _validator = new Validator<DataObject>();
            _familyMember = new FamilyMember();
            _income = new Income();
            _expenditure = new Expenditure();
            _incomeCategory = new Category();
            _expenditureCategory = new Category();

            _familyMember.FirstName = "Adam";
            _familyMember.LastName = "";

            _expenditureCategory.Name = "Jedzenie";
            _incomeCategory.Name = "";

            _income.Name = "Wyplata";
            _income.Amount = 1500M;
            _income.Category = _incomeCategory;
            _income.Person = _familyMember;
            _income.Constant = true;
            _income.Date = DateTime.Today.Date.ToString();

            _expenditure.Name = "Bulka";
            _expenditure.Amount = 0.8M;
            _expenditure.Category = _expenditureCategory;
            _expenditure.Person = _familyMember;
            _expenditure.Constant = false;
            _expenditure.Date = "";
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
            ValidationRule rule = new ValidationRule("FirstName", "required");

            bool expected = true;
            bool actual = _validator.Validate(rule, familyMember);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Income_Is_Valid()
        {
            Income income = _income;
            List<ValidationRule> rules = new List<ValidationRule>();
            rules.Add(new ValidationRule("name", "required"));
            rules.Add(new ValidationRule("amount", "required"));
            rules.Add(new ValidationRule("category", "required"));
            rules.Add(new ValidationRule("person", "required"));
            rules.Add(new ValidationRule("date", "required"));
            
            bool expected = true;
            bool actual = _validator.Validate(rules, income);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Expenditure_Is_Invalid()
        {
            Expenditure expenditure = _expenditure;
            List<ValidationRule> rules = new List<ValidationRule>();
            rules.Add(new ValidationRule("name", "required"));
            rules.Add(new ValidationRule("amount", "required"));
            rules.Add(new ValidationRule("category", "required"));
            rules.Add(new ValidationRule("person", "required"));
            rules.Add(new ValidationRule("date", "required"));

            bool expected = false;
            bool actual = _validator.Validate(rules, expenditure);

            Assert.AreEqual(expected, actual);
        }

        #region Expenditure Sub-tests

        //[Test]
        //public void _SUB_Expenditure_Name_Is_Valid()
        //{
        //    Expenditure expenditure = _expenditure;
        //    List<ValidationRule> rules = new List<ValidationRule>();
        //    rules.Add(new ValidationRule("name", "required"));

        //    bool expected = true;
        //    bool actual = _validator.Validate(rules, expenditure);

        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void _SUB_Expenditure_Amount_Is_Valid()
        //{
        //    Expenditure expenditure = _expenditure;
        //    List<ValidationRule> rules = new List<ValidationRule>();
        //    rules.Add(new ValidationRule("amount", "required"));

        //    bool expected = true;
        //    bool actual = _validator.Validate(rules, expenditure);

        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void _SUB_Expenditure_Category_Is_Valid()
        //{
        //    Expenditure expenditure = _expenditure;
        //    List<ValidationRule> rules = new List<ValidationRule>();
        //    rules.Add(new ValidationRule("category", "required"));

        //    bool expected = true;
        //    bool actual = _validator.Validate(rules, expenditure);

        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void _SUB_Expenditure_Person_Is_Valid()
        //{
        //    Expenditure expenditure = _expenditure;
        //    List<ValidationRule> rules = new List<ValidationRule>();
        //    rules.Add(new ValidationRule("person", "required"));


        //    bool expected = true;
        //    bool actual = _validator.Validate(rules, expenditure);

        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void _SUB_Expenditure_Date_Is_Invalid()
        //{
        //    Expenditure expenditure = _expenditure;
        //    ValidationRule rule = new ValidationRule("date", "required");

        //    bool expected = false;
        //    bool actual = _validator.Validate(rule, expenditure);

        //    Assert.AreEqual(expected, actual);
        //}

        #endregion

        [Test]
        public void Category_Is_Valid()
        {
            Category category = _expenditureCategory;
            ValidationRule rule = new ValidationRule("name", "required");

            bool expected = true;
            bool actual = _validator.Validate(rule, category);


            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Category_Is_Invalid()
        {
            Category category = _incomeCategory;
            ValidationRule rule = new ValidationRule("name", "required");

            bool expected = false;
            bool actual = _validator.Validate(rule, category);

            Assert.AreEqual(expected, actual);
        }


    }
}
