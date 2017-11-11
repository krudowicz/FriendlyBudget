using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.DAL.DTO
{
    public class Expenditure
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool Constant { get; set; }
        public ExpenditureCategory Category { get; set; }
        public FamilyMember FamilyMember { get; set; }
    }
}
