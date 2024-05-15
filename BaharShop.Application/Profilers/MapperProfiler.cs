using AutoMapper;
using BaharShop.Application.DTOs.Customers;
using BaharShop.Domain.Entities.Customers;

namespace BaharShop.Application.Profilers
{
    public class MapperProfiler : Profile
    {
        public MapperProfiler()
        {
            CreateMap<Customer, CustomerDTO>().ReverseMap();
        }
    }
}
