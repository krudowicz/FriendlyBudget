using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FriendlyBudget.LocalClient.Components.Validation;
using FriendlyBudget.LocalClient.Components.DAL.DTO;
using FriendlyBudget.LocalClient.Components.Core.Abstraction;

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
            bool expected = true;
            bool actual = false;


            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Income_Is_Valid()
        {
            bool expected = true;
            bool actual = false;


            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Expenditure_Is_Invalid()
        {
            bool expected = true;
            bool actual = false;


            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Category_Is_Valid()
        {
            bool expected = true;
            bool actual = false;


            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Category_Is_Invalid()
        {
            bool expected = true;
            bool actual = false;


            Assert.AreEqual(expected, actual);
        }


    }
}
