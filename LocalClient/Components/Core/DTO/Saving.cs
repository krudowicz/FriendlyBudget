using FriendlyBudget.LocalClient.Components.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.Core.DTO
{
    public class Saving : DataObject
    {
        public string Goal { get; set; }
        public Category Category { get; set; }
        public string StartDate { get; set; }
        public string DueDate { get; set; }
        public decimal MoneyAmountRequired { get; set; }
        public decimal MoneyAmountCurrent { get; set; }
        public FamilyMember FamilyMember { get; set; }
    }
}
