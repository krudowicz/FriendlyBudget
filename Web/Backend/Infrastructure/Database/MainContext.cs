using System;
using System.Collections.Generic;
using System.Text;
using FriendlyBudget.Web.Backend.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace FriendlyBudget.Web.Backend.Infrastructure.Database
{
    class MainContext : DbContext()
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<FamilyMember> FamilyMembers { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expenditure> Expenditures { get; set; }
        public DbSet<Saving> Savings { get; set; }
        public DbSet<Currency> Currencies { get; set; }
    }
}
