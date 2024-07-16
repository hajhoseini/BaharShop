using BaharShop.Common.Enums;
using BaharShop.Domain.Entities.Addresses;
using BaharShop.Domain.Entities.Categories;
using BaharShop.Domain.Entities.Cities;
using BaharShop.Domain.Entities.Comments;
using BaharShop.Domain.Entities.Customers;
using BaharShop.Domain.Entities.OrderItems;
using BaharShop.Domain.Entities.Orders;
using BaharShop.Domain.Entities.Products;
using BaharShop.Domain.Entities.Provinces;
using BaharShop.Domain.Entities.Roles;
using BaharShop.Domain.Entities.UserRoles;
using BaharShop.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace BaharShop.InfraStructure.DBContext
{
    public class BaharShopDBContext : DbContext
    {
        public BaharShopDBContext(DbContextOptions<BaharShopDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role { Id = 1, Name = nameof(UserRoles.Admin) });
            modelBuilder.Entity<Role>().HasData(new Role { Id = 2, Name = nameof(UserRoles.Operator) });
            modelBuilder.Entity<Role>().HasData(new Role { Id = 3, Name = nameof(UserRoles.Customer) });

            // اعمال ایندکس بر روی فیلد ایمیل
            // اعمال عدم تکراری بودن ایمیل
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();

            modelBuilder.Entity<User>().HasQueryFilter(p => !p.IsRemoved);
        }

        public DbSet<Address> Address { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<OrderItem> OrderItem{ get; set; }
        public DbSet<Order> Order{ get; set; }
        public DbSet<Product> Product{ get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<UserRole> UserRole { get; set; }

        public DbSet<ProductImage> ProductImage { get; set; }

        public DbSet<ProductFeature> ProductFeature { get; set; }
    }
}
