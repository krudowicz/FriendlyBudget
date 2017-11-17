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
        bool Validate(T item);
    }
}
