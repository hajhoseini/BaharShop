using BaharShop.Domain.Entities.Customers;
using BaharShop.Domain.IRepositories.Customers;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Repositories.Customers
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}