using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Infrastructure.Entities
{
    class Currency
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Country { get; set; }
        public string Symbol { get; set; }
        public string AddedAt { get; set; }
        public string ModifiedAt { get; set; }
    }
}
