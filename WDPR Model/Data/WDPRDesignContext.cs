using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WDPR_Model.Models;

namespace WDPR_Model.Data
{
    public class WDPRDesignContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WDPRDesign;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<AnonymousReport> AnonymousReports { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Flag> Flags { get; set; }
        public DbSet<AnonymousReportCategory> AnonymousReportCategories { get; set; }
        public DbSet<FlagCategory> FlagCategories { get; set; }
        public DbSet<PublicReport> PublicReports { get; set; }
        public DbSet<PublicReportCategory> PublicReportCategories { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                modelBuilder.Entity<Role>()
            .HasMany(c => c.Users)
            .WithOne(e => e.Role);

            modelBuilder.Entity<Address>()
          .HasMany(c => c.Users)
          .WithOne(e => e.Address);

            modelBuilder.Entity<FlagCategory>()
          .HasMany(c => c.Flags)
          .WithOne(e => e.FlagCategory);

            modelBuilder.Entity<User>()
          .HasMany(c => c.Flags)
          .WithOne(e => e.User);

            modelBuilder.Entity<User>()
          .HasMany(c => c.Comments)
          .WithOne(e => e.User);

            modelBuilder.Entity<User>()
          .HasMany(c => c.Likes)
          .WithOne(e => e.User);

            modelBuilder.Entity<User>()
          .HasMany(c => c.Reports)
          .WithOne(e => e.User);


            modelBuilder.Entity<Report>()
          .HasMany(c => c.Flags)
          .WithOne(e => e.Report);

            modelBuilder.Entity<Report>()
          .HasMany(c => c.Comments)
          .WithOne(e => e.Report);

            modelBuilder.Entity<Report>()
          .HasMany(c => c.Likes)
          .WithOne(e => e.Report);

            modelBuilder.Entity<PublicReportCategory>()
          .HasMany(c => c.PublicReports)
          .WithOne(e => e.publicReportCategory);

            modelBuilder.Entity<Vote>()
            .HasKey(o => new { o.ReportId, o.UserId });



        }

    }
    
}
