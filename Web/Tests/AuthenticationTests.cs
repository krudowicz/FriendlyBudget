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
        private IUser InvalidEmailUser { get; set; }
        private IUser InvalidPasswordUser { get; set; }
        private IUser InvalidEmailAndPasswordUser { get; set; }

        public AuthenticationTests()
        {
            TestUser = new UserDto();
            ValidUser = new UserDto();
            InvalidEmailUser = new UserDto();
            InvalidPasswordUser = new UserDto();
            InvalidEmailAndPasswordUser = new UserDto();
        }

        [OneTimeSetUp]
        public void Setup()
        {
            UTF8Encoding encoding = new UTF8Encoding();
            SHA256CryptoServiceProvider cryptoService = new SHA256CryptoServiceProvider();

            TestUser.Username = "Correctname";
            TestUser.Password = BCrypt.Net.BCrypt.HashPassword("Correctpassword");

            ValidUser.Username = "Correctname";
            ValidUser.Password = "Correctpassword";

            InvalidEmailUser.Username = "Incorrectname";
            InvalidEmailUser.Password = "Correctpassword";

            InvalidPasswordUser.Username = "Correctname";
            InvalidPasswordUser.Password = "Incorrectpassword";

            InvalidEmailAndPasswordUser.Username = "Incorrectusername";
            InvalidEmailAndPasswordUser.Password = "Incorrectpassword";
        }

        [OneTimeTearDown]
        public void Teardown()
        {
            TestUser = null;
            ValidUser = null;
            InvalidEmailUser = null;
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
            bool result = Authenticator.Authenticate(InvalidEmailUser, null, new EmailAuthentication());

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
