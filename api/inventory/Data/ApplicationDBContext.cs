using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inventory.Models;
using Microsoft.EntityFrameworkCore;

namespace inventory.Data
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
            
        }
         public DbSet<Product> Products { get; set; }
    // public DbSet<User> Users { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<SalesSummary> SalesSummaries { get; set; }
    public DbSet<Purchase> Purchases { get; set; }
    public DbSet<PurchaseSummary> PurchaseSummaries { get; set; }
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<ExpenseSummary> ExpenseSummaries { get; set; }
    public DbSet<ExpenseByCategory> ExpenseByCategories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Sale>()
            .HasOne(x => x.Product)
            .WithMany(p => p.Sales)
            .HasForeignKey(x => x.ProductId);

        modelBuilder.Entity<Purchase>()
            .HasOne(x => x.Product)
            .WithMany(p => p.Purchases)
            .HasForeignKey(x => x.ProductId);

        modelBuilder.Entity<ExpenseByCategory>()
            .HasOne(x => x.ExpenseSummary)
            .WithMany(e => e.ExpenseByCategories)
            .HasForeignKey(x => x.ExpenseSummaryId);

            // add config
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDBContext).Assembly);
    }
    
    }
}