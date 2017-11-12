using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Core.Abstraction;

namespace FriendlyBudget.LocalClient.Components.DAL.DTO
{
    public class Income : MoneyObject
    {
        public IncomeCategory Category { get; set; }
    }
}
