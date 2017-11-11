using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.DAL.DTO
{
    public class ExpenditureCategory
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool DefaultConstant { get; set; }
        public List<ExpenditureCategory> Subcategories { get; set; }
        public List<Expenditure> Expenditures { get; set; }
    }
}
