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
    }
}
