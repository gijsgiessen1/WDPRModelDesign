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
        public DbSet<Anonymous_Report> Anonymous_Reports { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Flag> Flags { get; set; }
        public DbSet<Flagged_Comment> Flagged_Comments { get; set; }
        public DbSet<Flagged_Report> Flagged_Reports { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Moderator> Moderators { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<User_Address> User_Addresses { get; set; }
        public DbSet<User_Comment> User_Comments { get; set; }
        public DbSet<User_Report> User_Reports { get; set; }
    }
}
