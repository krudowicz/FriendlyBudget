using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using FriendlyBudget.LocalClient.Components.Core.DTO;

namespace FriendlyBudget.LocalClient.Components.DAL.Database
{
    internal class MainContext : DbContext
    {
        public DbSet<FamilyMember> FamilyMembers { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expenditure> Expenditures { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Saving> Savings { get; set; }
    }
}
