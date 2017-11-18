using FriendlyBudget.LocalClient.Components.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.DAL.DTO
{
    public class ValidationRule : DataObject
    {

        public string LinkedEntityType { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }

    }
}
