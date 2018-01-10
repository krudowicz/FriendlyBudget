﻿using FriendlyBudget.LocalClient.Components.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.DomainModel
{
    class Income : MoneyObject
    {
        public Category Category { get; set; }

        public Income() : base()
        {
            Category = null;
        }
    }
}
