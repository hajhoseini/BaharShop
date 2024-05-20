using BaharShop.Domain.IReaders;
using BaharShop.Domain.IReaders.Customers;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.IRepositories.Customers;
using BaharShop.InfraStructure.Readers;
using BaharShop.InfraStructure.Readers.Customers;
using BaharShop.InfraStructure.Repositories;
using BaharShop.InfraStructure.Repositories.Customers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaharShop.InfraStructure
{
    public static class DIContainer
    {
        public static IServiceCollection InfraStructureServiceCollections(this IServiceCollection service)
        {
            service.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            service.AddScoped<ICustomerRepository, CustomerRepository>();

            service.AddScoped(typeof(IGenericReader<>), typeof(GenericReader<>));
            service.AddScoped<ICustomerReader, CustomerReader>();

            return service;
        }
    }
}
