using FriendlyBudget.LocalClient.Components.Core.Abstraction;
using FriendlyBudget.LocalClient.Components.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.App.ViewModels
{
    class FamilyViewModel : ViewModel
    {
        public List<FamilyMember> FamilyMembers { get; set; }
        public List<Income> Incomes { get; set; }
        public List<Expenditure> Expenditures { get; set; }
    }
}
