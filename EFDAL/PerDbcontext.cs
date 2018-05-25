using EFEntity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDAL
{
    public class PerDbContext : DbContext
    {
        public PerDbContext(DbContextOptions<PerDbContext> options) : base(options)
        {

        }

        public DbSet<User> User { set; get; }

        public DbSet<Department> Department { set; get; }

        public DbSet<Role> Role { set; get; }

        public DbSet<UserRole> UserRole { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
        }

    }
}
