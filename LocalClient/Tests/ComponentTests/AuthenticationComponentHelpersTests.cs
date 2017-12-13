using System;
using NUnit.Framework;
using FriendlyBudget.LocalClient.Components.DAL.DTO;
using FriendlyBudget.LocalClient.Components.AuthenticationComponent.Helpers;

namespace FriendlyBudget.LocalClient.Tests.ComponentTests
{
    [TestFixture]
    public class AuthenticationComponentHelpersTests
    {
        User _user;

        [SetUp]
        public void Init()
        {
            _user = new User();
            _user.Password = "Password1234";
        }

        [TearDown]
        public void Cleanup()
        {
            _user.Password = string.Empty;
            _user = null;
        }

        [Test]
        public void Provided_Password_Matches_User_Password()
        {
            string providedPassword = "Password1234";

            string hashedProvidedPassword = PasswordEncoder.Encode(providedPassword);
            string hashedUserPassword = PasswordEncoder.Encode(_user.Password);

            bool result = PasswordComparer.ComparePasswords(hashedProvidedPassword, hashedUserPassword);

            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_Password_Does_Not_Match_User_Password()
        {
            string providedPassword = "Dupa885";

            string hashedProvidedPassword = PasswordEncoder.Encode(providedPassword);
            string hashedUserPassword = PasswordEncoder.Encode(_user.Password);

            bool result = PasswordComparer.ComparePasswords(hashedProvidedPassword, hashedUserPassword);

            Assert.IsFalse(result);
        }
    }
}
