using BugTracker.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BugTracker.DataAccess
{
    public class BugTrackerDb : DbContext
    {
        public DbSet<Issue> Issues { get; set; }
        //public DbSet<IssueEvent> Events { get; set; }
        //public DbSet<Product> Products { get; set; }
        //public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }

        public BugTrackerDb(DbContextOptions<BugTrackerDb> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
