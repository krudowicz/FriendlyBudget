using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.Core.Interfaces
{
    public interface IReader
    {
        Dictionary<string, string> Read(string source, string format, bool structured); //TODO: Consider the way to implement this.
    }
}
