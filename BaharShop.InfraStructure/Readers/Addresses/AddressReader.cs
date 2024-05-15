using BaharShop.Domain.Entities.Addresses;
using BaharShop.Domain.IReaders.Addresses;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Readers.Addresss
{
    public class AddressReader : GenericReader<Address>, IAddressReader
    {
        public AddressReader(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}