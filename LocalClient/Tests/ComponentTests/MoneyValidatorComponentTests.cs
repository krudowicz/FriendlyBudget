using System;
using NUnit.Framework;
using FriendlyBudget.LocalClient.Components.DAL.DTO;
using FriendlyBudget.LocalClient.Components.Validation.MoneyValidatorComponent;

namespace FriendlyBudget.LocalClient.Tests.ComponentTests
{
    [TestFixture]
    public class MoneyValidatorComponentTests
    {
        private Income validMoneyObject;
        private Expenditure invalidMoneyObject;
        private MoneyValidator validator;

        [SetUp]
        public void SetUp()
        {
            validMoneyObject = new Income();
            invalidMoneyObject = new Expenditure();
            FamilyMember familyMember = new FamilyMember();

            validMoneyObject.Amount = 100;
            validMoneyObject.Name = "Jedzenie";
            validMoneyObject.Date = DateTime.Today;
            validMoneyObject.FamilyMember = familyMember;

            invalidMoneyObject.Amount = 0;
            invalidMoneyObject.Name = "Gry";
            invalidMoneyObject.Date = DateTime.Today;

            validator = new MoneyValidator();
        }

        [TearDown]
        public void CleanUp()
        {
            validMoneyObject = null;
            invalidMoneyObject = null;
            validator = null;
        }

        [Test]
        public void Income_ValidMoneyObject_Is_Validated()
        {
            Income income = validMoneyObject;

            bool actual = validator.Validate(income);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Expenditure_InvalidMoneyObject_Is_Not_Validated()
        {
            Expenditure expenditure = invalidMoneyObject;

            bool actual = validator.Validate(expenditure);
            bool expected = false;

            Assert.AreEqual(expected, actual);
        }
    }
}
