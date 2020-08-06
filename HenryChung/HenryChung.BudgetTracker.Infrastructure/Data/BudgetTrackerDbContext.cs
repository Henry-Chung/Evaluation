using HenryChung.BudgetTracker.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HenryChung.BudgetTracker.Infrastructure.Data
{
    public class BudgetTrackerDbContext : DbContext
    {
        public BudgetTrackerDbContext(DbContextOptions<BudgetTrackerDbContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Incomes> Incomes { get; set; }
        public DbSet<Expenditures> Expenditures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(ConfigureUsers);
            modelBuilder.Entity<Expenditures>(ConfigureExpenditures);
            modelBuilder.Entity<Incomes>(ConfigureIncomes);
        }

        private void ConfigureUsers(EntityTypeBuilder<Users> modelBuilder)
        {
            modelBuilder.ToTable("Users");
            modelBuilder.HasKey(u => u.Id);
            modelBuilder.Property(u => u.Email).HasMaxLength(50).IsRequired();
            modelBuilder.Property(u => u.Password).HasMaxLength(10).IsRequired();
            modelBuilder.Property(u => u.Fullname).HasMaxLength(50);
            modelBuilder.Property(u => u.JoinedOn).HasColumnType("datetime2").HasDefaultValueSql("getdate()");
        }

        private void ConfigureExpenditures(EntityTypeBuilder<Expenditures> modelBuilder)
        {
            modelBuilder.ToTable("Expenditures");
            modelBuilder.HasKey(e => e.Id);
            modelBuilder.Property(e => e.Amount).HasColumnType("decimal(5, 2)").IsRequired();
            modelBuilder.Property(e => e.Description).HasMaxLength(100);
            modelBuilder.Property(e => e.ExpDate).HasColumnType("datetime2");
            modelBuilder.Property(e => e.Remarks).HasMaxLength(500);
        }

        private void ConfigureIncomes(EntityTypeBuilder<Incomes> modelBuilder)
        {
            modelBuilder.ToTable("Incomes");
            modelBuilder.HasKey(i => i.Id);
            modelBuilder.Property(i => i.Amount).HasColumnType("decimal(5, 2)").IsRequired();
            modelBuilder.Property(i => i.Description).HasMaxLength(100);
            modelBuilder.Property(i => i.IncomeDate).HasColumnType("datetime2");
            modelBuilder.Property(i => i.Remarks).HasMaxLength(500);
        }
    }
}
