using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.Core.System
{
    class Configuration
    {
        public Dictionary<string, string> DatabaseConfiguration { get; set; }
        public Dictionary<string, string> LocalConfiguration { get; set; }
        public Dictionary<string, string> GlobalConfiguration { get; set; }
    }
}
