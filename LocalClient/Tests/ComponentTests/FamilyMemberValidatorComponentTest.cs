using System;
using NUnit.Framework;
using FriendlyBudget.LocalClient.Components.DAL.DTO;
using FriendlyBudget.LocalClient.Components.Validation.FamilyMemberValidatorComponent;

namespace FriendlyBudget.LocalClient.Tests.ComponentTests
{
    [TestFixture]
    public class FamilyMemberValidatorComponentTest
    {
        private FamilyMember validFamilyMember;
        private FamilyMember invalidFamilyMember;
        private FamilyMemberValidator validator;

        [SetUp]
        public void SetUp()
        {
            validFamilyMember = new FamilyMember();
            invalidFamilyMember = new FamilyMember();

            validFamilyMember.FirstName = "Adam";
            validFamilyMember.LastName = "Lopez";

            invalidFamilyMember.FirstName = "Kamil";
            invalidFamilyMember.LastName = String.Empty;

            validator = new FamilyMemberValidator();
        }

        [TearDown]
        public void CleanUp()
        {
            validFamilyMember = null;
            invalidFamilyMember = null;
        }

        [Test]
        public void ValidFamilyMember_Is_Validated()
        {
            FamilyMember familyMember = validFamilyMember;

            bool actual = validator.Validate(familyMember);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InvalidFamilyMember_Is_Not_Validated()
        {
            FamilyMember familyMember = invalidFamilyMember;

            bool actual = validator.Validate(familyMember);
            bool expected = false;

            Assert.AreEqual(expected, actual);
        }
    }
}
