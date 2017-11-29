using FriendlyBudget.LocalClient.Components.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.AuthorizationComponent
{
    public class Authorizer<T> : IAuthorizer<T>
    {

        #region Public Methods

        public bool Authorize(T user)
        {
            bool result = AuthorizeInternal(user);
            return result;
        }

        #endregion

        #region Methods

        private bool AuthorizeInternal(T user)
        {
            bool authorized = false;
            throw new NotImplementedException();
        }

        #endregion
    }
}
