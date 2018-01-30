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
        [Test]
        public void User_Is_Authenticated_By_Email()
        {
            IUser user = new UserDto();

            bool result = Authenticator.Authenticate(user, new EmailAuthentication());

            Assert.IsTrue(result);
        }

        [Test]
        public void User_Provided_Wrong_Password()
        {
            IUser user = new UserDto();

            bool result = Authenticator.Authenticate(user, new EmailAuthentication());

            Assert.IsFalse(result);
        }

        [Test]
        public void Email_Does_Not_Exist()
        {
            IUser user = new UserDto();

            bool result = Authenticator.Authenticate(user, new EmailAuthentication());

            Assert.IsFalse(result);
        }
    }
}
