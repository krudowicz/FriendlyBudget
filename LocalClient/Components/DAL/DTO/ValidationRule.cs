using FriendlyBudget.LocalClient.Components.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.DAL.Entities
{
    class ValidationRule : DataObject
    {

        public string LinkedEntityType { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }

        public ValidationRule()
        {
            LinkedEntityType = String.Empty;
            Name = String.Empty;
            Content = String.Empty;
        }

        public ValidationRule(string name, string content)
        {
            Name = name;
            Content = content;
        }

        public ValidationRule(string linkedEntityType, string name, string content)
        {
            LinkedEntityType = linkedEntityType;
            Name = name;
            Content = content;
        }
    }
}
