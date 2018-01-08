using FriendlyBudget.LocalClient.Components.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.Core.DTO
{
    public class Role : DataObject
    {
        public string Name { get; set; }
        public bool Read { get; set; }
        public bool Write { get; set; }
    }
}
