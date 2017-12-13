using FriendlyBudget.LocalClient.Components.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.App.ViewModels
{
    class FamilyMemberViewModel
    {

        public FamilyMember FamilyMember { get; set; }
        public ICollection<Expenditure> Expenditures { get; set; }

        public FamilyMemberViewModel()
        {

        }
    }
}
