using BCrypt;
using FriendlyBudget.Web.Backend.Infrastructure.DTO;
using FriendlyBudget.Web.Backend.Model.Application_Services.Authentication;
using FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Strategies;
using FriendlyBudget.Web.Backend.Model.Interfaces;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace FriendlyBudget.Web.Tests
{
    [TestFixture]
    class AuthenticationTests
    {
        private IUser TestUser { get; set; }
        private IUser ValidUser { get; set; }
        private IUser InvalidUser { get; set; }
        private IUser InvalidPasswordUser { get; set; }
        private IUser InvalidEmailAndPasswordUser { get; set; }

        public AuthenticationTests()
        {
            TestUser = new UserDto();
            ValidUser = new UserDto();
            InvalidUser = new UserDto();
            InvalidPasswordUser = new UserDto();
            InvalidEmailAndPasswordUser = new UserDto();
        }

        [OneTimeSetUp]
        public void Setup()
        {
            string passwordSalt = BCryptHelper.GenerateSalt(14);

            TestUser.Email = "Correct@mail.com";
            TestUser.Username = "Correctname";
            TestUser.Password = BCryptHelper.HashPassword("Correctpassword", passwordSalt);

            ValidUser.Email = "Correct@mail.com";
            ValidUser.Username = "Correctname";
            ValidUser.Password = "Correctpassword";

            InvalidUser.Email = "Incorrectorrect@mail.com";
            InvalidUser.Username = "Incorrectname";
            InvalidUser.Password = "Correctpassword";

            InvalidPasswordUser.Username = "Correctname";
            InvalidPasswordUser.Password = "Incorrectpassword";

            InvalidEmailAndPasswordUser.Email = "Incorrectorrect@mail.com";
            InvalidEmailAndPasswordUser.Username = "Incorrectusername";
            InvalidEmailAndPasswordUser.Password = "Incorrectpassword";
        }

        //TODO: Rewrite the tests to match reality and tested parts.
        [OneTimeTearDown]
        public void Teardown()
        {
            TestUser = null;
            ValidUser = null;
            InvalidUser = null;
            InvalidPasswordUser = null;
            InvalidEmailAndPasswordUser = null;
        }

        [Test]
        public void User_Is_Authenticated_By_Email()
        {
            bool result = Authenticator.Authenticate(ValidUser, TestUser, new EmailAuthentication());

            Assert.IsTrue(result);
        }

        [Test]
        public void User_Provided_Wrong_Password()
        {
            bool test()
            {
                return Authenticator.Authenticate(InvalidPasswordUser, TestUser, new EmailAuthentication());
            }

            Assert.IsFalse(test());
        }

        [Test]
        public void Email_Does_Not_Exist()
        {
            bool result = Authenticator.Authenticate(InvalidUser, null, new EmailAuthentication());

            Assert.IsFalse(result);
        }

        [Test]
        public void Email_Does_Not_Exist_And_Password_Is_Invalid()
        {
            bool result = Authenticator.Authenticate(InvalidEmailAndPasswordUser, null, new EmailAuthentication());

            Assert.IsFalse(result);
        }
    }
}
