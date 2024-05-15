using BaharShop.Domain.Entities.Addresses;
using BaharShop.Domain.IRepositories.Addresses;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Repositories.Addresses
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}