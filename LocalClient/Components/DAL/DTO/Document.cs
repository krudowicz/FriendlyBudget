using FriendlyBudget.LocalClient.Components.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.DAL.DTO
{
    /// <summary>
    /// Document DTO, not used at the moment, but will be in the future with Documents implementation.
    /// SHOULD NOT BE USED RIGHT NOW!
    /// </summary>
    public class Document : DataObject
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public FamilyMember FamilyMember { get; set; }
        public DateTime Date { get; set; }
    }
}
