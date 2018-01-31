using FriendlyBudget.Web.Backend.Infrastructure.DTO;
using FriendlyBudget.Web.Backend.Model.Application_Services.Authentication;
using FriendlyBudget.Web.Backend.Model.Application_Services.Authentication.Strategies;
using FriendlyBudget.Web.Backend.Model.Interfaces;
using NUnit.Framework;

namespace FriendlyBudget.Web.Tests
{
    [TestFixture]
    class AuthenticationTests
    {
        private IUser ValidUser { get; set; }
        private IUser InvalidEmailUser { get; set; }
        private IUser InvalidPasswordUser { get; set; }
        private IUser InvalidEmailAndPasswordUser { get; set; }

        private string CorrectUsername { get; set; }
        private string CorrectPassword { get; set; }

        public AuthenticationTests()
        {
            ValidUser = new UserDto();
            InvalidEmailUser = new UserDto();
            InvalidPasswordUser = new UserDto();
            InvalidEmailAndPasswordUser = new UserDto();
        }

        [OneTimeSetUp]
        public void Setup()
        {
            ValidUser.Username = "Correctname";
            ValidUser.Password = "Correctpassword";

            InvalidEmailUser.Username = "Incorrectname";
            InvalidEmailUser.Password = "Correctpassword";

            InvalidPasswordUser.Username = "Correctname";
            InvalidPasswordUser.Password = "Incorrectpassword";

            InvalidEmailAndPasswordUser.Username = "Incorrectusername";
            InvalidEmailAndPasswordUser.Password = "Incorrectpassword";

            CorrectUsername = "Correctusername";
            CorrectPassword = "Correctpassword";
        }

        [OneTimeTearDown]
        public void Teardown()
        {
            ValidUser = null;
            InvalidEmailUser = null;
            InvalidPasswordUser = null;
            InvalidEmailAndPasswordUser = null;
            CorrectUsername = string.Empty;
            CorrectPassword = string.Empty;
        }

        [Test]
        public void User_Is_Authenticated_By_Email()
        {
            bool result = Authenticator.Authenticate(ValidUser, ValidUser, new EmailAuthentication());

            Assert.IsTrue(result);
        }

        [Test]
        public void User_Provided_Wrong_Password()
        {
            bool result = Authenticator.Authenticate(InvalidPasswordUser, ValidUser, new EmailAuthentication());

            Assert.IsFalse(result);
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
