using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.Core.Abstraction
{
    public abstract class Person : DataObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
