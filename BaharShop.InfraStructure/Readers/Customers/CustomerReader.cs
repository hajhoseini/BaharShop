using BaharShop.Domain.Entities.Customers;
using BaharShop.Domain.IReaders.Customers;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Readers.Customers
{
    public class CustomerReader : GenericReader<Customer>, ICustomerReader
    {
        public CustomerReader(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}