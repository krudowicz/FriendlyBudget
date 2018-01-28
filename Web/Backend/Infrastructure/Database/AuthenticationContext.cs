using FriendlyBudget.Web.Backend.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyBudget.Web.Backend.Infrastructure.Database
{
    class AuthenticationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
