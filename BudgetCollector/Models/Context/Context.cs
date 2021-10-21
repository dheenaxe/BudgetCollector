using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BudgetCollector.Models
{
    public class Context : DbContext
    {
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}