using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.DAL.DTO
{
    /// <summary>
    /// Document DTO, not used at the moment, but will be in the future with Documents implementation.
    /// </summary>
    public class Document
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public FamilyMember FamilyMember { get; set; }
        public DateTime Date { get; set; }
    }
}
