using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.DAL.DTO
{
    public class IncomeCategory
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool DefaultConstant { get; set; }
        public List<IncomeCategory> Subcategories { get; set; }
        public List<Income> Incomes { get; set; }
    }
}
