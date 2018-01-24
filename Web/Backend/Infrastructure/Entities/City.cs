using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace FriendlyBudget.Web.Backend.Infrastructure.Entities
{
    class City
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public string ZipCode { get; set; }
        public Region Region { get; set; }
        public ulong NumberOfCitizens { get; set; }
        public SqlMoney AverageIncome { get; set; }
        public SqlMoney AverageExpenditure { get; set; }
        public SqlMoney MedianIncome { get; set; }
        public SqlMoney MedianExpenditure { get; set; }
        public string AddedAt { get; set; }
        public string ModifiedAt { get; set; }
    }
}
