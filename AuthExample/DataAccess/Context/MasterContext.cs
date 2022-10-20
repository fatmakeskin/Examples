using AuthExample.Business.Extension;
using AuthExample.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace AuthExample.DataAccess.Context
{
    public class MasterContext:DbContext
    {
        public MasterContext(DbContextOptions<MasterContext> options) : base(options) { }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<ApplicationUser> applicationUsers { get; set; } 
    }
}
