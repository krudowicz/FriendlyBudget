using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.Core.Abstraction
{
    public class ValidatorCore<T>
    {
        protected T _entity;
        protected Dictionary<string, string> _ruleSet;

        protected virtual void TryValidate()
        {
            throw new NotImplementedException();   
        }
    }
}
