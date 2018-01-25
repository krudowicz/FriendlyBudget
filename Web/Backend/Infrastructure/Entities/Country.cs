using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace FriendlyBudget.Web.Backend.Infrastructure.Entities
{
    class Country
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public List<Region> Regions { get; set; }
        public SqlMoney AverageIncome { get; set; }
        public SqlMoney AverageExpenditure { get; set; }
        public SqlMoney MedianIncome { get; set; }
        public SqlMoney MedianExpenditure { get; set; }
        public string AddedAt { get; set; }
        public string ModifiedAt { get; set; }
    }
}
