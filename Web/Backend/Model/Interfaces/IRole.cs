using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Model.Interfaces
{
    interface IRole
    {
        string Name { get; set; }
        bool Read { get; set; }
        bool Write { get; set; }
    }
}
