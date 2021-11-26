using Clean_Store.Application.Interfaces.Contexts;
using Clean_Store.Common.Roles;
using Clean_Store.Domain.Entities.Products;
using Clean_Store.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clean_Store.Persistence.Contexts
{
    public class DatabaseContext:DbContext , IDatabaseContext
    {
        public DatabaseContext(DbContextOptions options) :base (options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserInRole> UserInRoles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        public DbSet<ProductFeatures> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //مقداردهی اولیه به جدول نقش ها
            seedData(modelBuilder);
            
            //ایندکس گذاری و تکراری نبودن فیلد ایمیل
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();

            // نشان ندادن اطاعاتی که حذف شده اند
            ApplyQueryFilter(modelBuilder);
        }

        private void seedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role { Id = 1, Name = nameof(UserRoles.Admin) });
            modelBuilder.Entity<Role>().HasData(new Role { Id = 2, Name = nameof(UserRoles.Operator) });
            modelBuilder.Entity<Role>().HasData(new Role { Id = 3, Name = nameof(UserRoles.Customer) });
        }

        private void ApplyQueryFilter(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<Role>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<UserInRole>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<Category>().HasQueryFilter(p => !p.IsRemoved);
        }
    }
}