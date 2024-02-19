using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class FlattyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Flatty;Trusted_Connection=true");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Balance> Balances { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Configure the many-to-many relationship between Group and User
        //    modelBuilder.Entity<Balance>()
        //        .HasKey(gu => new { gu.GroupId, gu.UserId });

        //    modelBuilder.Entity<Balance>()
        //        .HasOne(gu => gu.Group)
        //        .WithMany(g => g.Balance)
        //        .HasForeignKey(gu => gu.GroupId);

        //    modelBuilder.Entity<Balance>()
        //        .HasOne(gu => gu.User)
        //        .WithMany(u => u.Balance)
        //        .HasForeignKey(gu => gu.UserId);
        //}

    }
}
    

