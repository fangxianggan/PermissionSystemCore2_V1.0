using EFEntity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            base.OnModelCreating(modelBuilder);


            //查找所有FluentAPI配置
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes().Where(q => q.GetInterface(typeof(IEntityTypeConfiguration<>).FullName) != null);

            //应用FluentAPI
            foreach (var type in typesToRegister)
            {
                //dynamic使C#具有弱语言的特性，在编译时不对类型进行检查

                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.ApplyConfiguration(configurationInstance);
            }
        }

    }
}
