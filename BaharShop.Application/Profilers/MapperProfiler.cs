using AutoMapper;
using BaharShop.Application.DTOs.Categories;
using BaharShop.Application.DTOs.Cities;
using BaharShop.Application.DTOs.Customers;
using BaharShop.Application.DTOs.Products;
using BaharShop.Domain.Entities.Categories;
using BaharShop.Domain.Entities.Cities;
using BaharShop.Domain.Entities.Customers;
using BaharShop.Domain.Entities.Products;

namespace BaharShop.Application.Profilers
{
    public class MapperProfiler : Profile
    {
        public MapperProfiler()
        {
            CreateMap<Customer, CustomerDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<City, CityDTO>().ReverseMap();
        }
    }
}
