using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.Core.Interfaces
{
    public interface IValidator<T>
    {
        bool IsValid { get; set; }
        bool Validate(string entityType, T entity);
        bool Validate(Dictionary<string, string> ruleSet, T entity);
        bool Validate(string field, string rule, T entity);
    }
}
