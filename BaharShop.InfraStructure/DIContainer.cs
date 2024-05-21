﻿using BaharShop.Domain.IReaders;
using BaharShop.Domain.IReaders.Addresses;
using BaharShop.Domain.IReaders.Categories;
using BaharShop.Domain.IReaders.Cities;
using BaharShop.Domain.IReaders.Comments;
using BaharShop.Domain.IReaders.Customers;
using BaharShop.Domain.IReaders.OrderItems;
using BaharShop.Domain.IReaders.Orders;
using BaharShop.Domain.IReaders.Products;
using BaharShop.Domain.IReaders.Provinces;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.IRepositories.Addresses;
using BaharShop.Domain.IRepositories.Categories;
using BaharShop.Domain.IRepositories.Cities;
using BaharShop.Domain.IRepositories.Comments;
using BaharShop.Domain.IRepositories.Customers;
using BaharShop.Domain.IRepositories.OrderItems;
using BaharShop.Domain.IRepositories.Orders;
using BaharShop.Domain.IRepositories.Products;
using BaharShop.Domain.IRepositories.Provinces;
using BaharShop.InfraStructure.Readers;
using BaharShop.InfraStructure.Readers.Addresss;
using BaharShop.InfraStructure.Readers.Categories;
using BaharShop.InfraStructure.Readers.Cities;
using BaharShop.InfraStructure.Readers.Comments;
using BaharShop.InfraStructure.Readers.Customers;
using BaharShop.InfraStructure.Readers.OrderItems;
using BaharShop.InfraStructure.Readers.Orders;
using BaharShop.InfraStructure.Readers.Products;
using BaharShop.InfraStructure.Readers.Provinces;
using BaharShop.InfraStructure.Repositories;
using BaharShop.InfraStructure.Repositories.Addresses;
using BaharShop.InfraStructure.Repositories.Categories;
using BaharShop.InfraStructure.Repositories.Cities;
using BaharShop.InfraStructure.Repositories.Comments;
using BaharShop.InfraStructure.Repositories.Customers;
using BaharShop.InfraStructure.Repositories.OrderItems;
using BaharShop.InfraStructure.Repositories.Orders;
using BaharShop.InfraStructure.Repositories.Products;
using BaharShop.InfraStructure.Repositories.Provinces;
using Microsoft.Extensions.DependencyInjection;

namespace BaharShop.InfraStructure
{
    public static class DIContainer
    {
        public static IServiceCollection InfraStructureServiceCollections(this IServiceCollection service)
        {
            service.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            service.AddScoped<IAddressRepository, AddressRepository>();
            service.AddScoped<ICategoryRepository, CategoryRepository>();
            service.AddScoped<ICityRepository, CityRepository>();
            service.AddScoped<ICommentRepository, CommentRepository>();
            service.AddScoped<ICustomerRepository, CustomerRepository>();
            service.AddScoped<IOrderItemRepository, OrderItemRepository>();
            service.AddScoped<IOrderRepository, OrderRepository>();
            service.AddScoped<IProductRepository, ProductRepository>();
            service.AddScoped<IProvinceRepository, ProvinceRepository>();

            service.AddScoped(typeof(IGenericReader<>), typeof(GenericReader<>));

            service.AddScoped<IAddressReader, AddressReader>();
            service.AddScoped<ICategoryReader, CategoryReader>();
            service.AddScoped<ICityReader, CityReader>();
            service.AddScoped<ICommentReader, CommentReader>();
            service.AddScoped<ICustomerReader, CustomerReader>();
            service.AddScoped<IOrderItemReader, OrderItemReader>();
            service.AddScoped<IOrderReader, OrderReader>();
            service.AddScoped<IProductReader, ProductReader>();
            service.AddScoped<IProvinceReader, ProvinceReader>();

            return service;
        }
    }
}
