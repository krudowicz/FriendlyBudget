using FriendlyBudget.LocalClient.Components.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.DAL.DTO
{
    public class Category : DataObject
    {

        public string Name { get; set; }
        public bool ConstantByDefault { get; set; }
        public List<Category> Subcategories { get; set; }
        public List<MoneyObject> MoneyObjects { get; set; }

    }
}
