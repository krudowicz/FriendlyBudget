using FriendlyBudget.Web.Backend.Model.Value_Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Infrastructure.Entities
{
    class Region
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public List<City> Cities { get; set; }
        public Country Country { get; set; }
        public Money AverageIncome { get; set; }
        public Money AverageExpenditure { get; set; }
        public Money MedianIncome { get; set; }
        public Money MedianExpenditure { get; set; }
        public string AddedAt { get; set; }
        public string ModifiedAt { get; set; }
    }
}
