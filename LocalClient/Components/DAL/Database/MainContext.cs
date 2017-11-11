using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using FriendlyBudget.LocalClient.Components.DAL.DTO;

namespace FriendlyBudget.LocalClient.Components.DAL.Database
{
    class MainContext : DbContext
    {
        public DbSet<FamilyMember> FamilyMembers { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expenditure> Expenditures { get; set; }
        public DbSet<IncomeCategory> IncomeCategories { get; set; }
        public DbSet<ExpenditureCategory> ExpenditureCategories { get; set; }
    }
}
