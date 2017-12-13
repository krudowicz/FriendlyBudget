using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Components.Core.Abstraction;

namespace FriendlyBudget.LocalClient.Components.DAL.DTO
{
    public class FamilyMember : Person
    {
        public List<Income> Incomes { get; set; }
        public List<Expenditure> Expenditures { get; set; }
        public List<Saving> Savings { get; set; }
        public decimal BudgetSet { get; set; }
        public decimal BudgetBalance { get; set; }
        public decimal Balance { get; set; }
    }
}
