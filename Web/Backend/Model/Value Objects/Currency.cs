using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Model.Value_Objects
{
    class Currency
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Rate { get; set; }
        public string LocalName { get; set; }
    }
}
