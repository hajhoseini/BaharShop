using BaharShop.Domain.Entities.Provinces;
using BaharShop.Domain.IReaders.Provinces;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Readers.Provinces
{
    public class ProvinceReader : GenericReader<Province>, IProvinceReader
    {
        public ProvinceReader(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}
