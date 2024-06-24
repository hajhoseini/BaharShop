using AutoMapper;
using BaharShop.Application.DTOs.Addresses;
using BaharShop.Application.DTOs.Categories;
using BaharShop.Application.DTOs.Cities;
using BaharShop.Application.DTOs.Comments;
using BaharShop.Application.DTOs.Customers;
using BaharShop.Application.DTOs.OrderItems;
using BaharShop.Application.DTOs.Orders;
using BaharShop.Application.DTOs.Products;
using BaharShop.Application.DTOs.Provinces;
using BaharShop.Application.DTOs.Roles;
using BaharShop.Application.DTOs.UserRoles;
using BaharShop.Application.DTOs.Users;
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

namespace BaharShop.Application.Profilers
{
    public class MapperProfiler : Profile
    {
        public MapperProfiler()
        {
            CreateMap<Address, AddressDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<City, CityDTO>().ReverseMap();
            CreateMap<Comment, CommentDTO>().ReverseMap();
            CreateMap<Customer, CustomerDTO>().ReverseMap();
            CreateMap<OrderItem, OrderItemDTO>().ReverseMap();
            CreateMap<Order, OrderDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Province, ProvinceDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Role, RoleDTO>().ReverseMap();
            CreateMap<UserRole, UserRoleDTO>().ReverseMap();
        }
    }
}
