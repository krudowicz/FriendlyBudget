using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Components.Core.Abstraction;

namespace FriendlyBudget.LocalClient.Components.DAL.DTO
{
    public class Expenditure : MoneyObject
    {
        public Category Category { get; set; }
    }
}
