using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.Core.Abstraction
{
    public abstract class MoneyObject : DataObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Date { get; set; }
        public bool Constant { get; set; }
        public Person Person { get; set; }

        public MoneyObject()
        {
            Name = string.Empty;
            Description = string.Empty;
            Amount = 0;
            Date = string.Empty;
            Constant = false;
            Person = null;
        }
    }
}
