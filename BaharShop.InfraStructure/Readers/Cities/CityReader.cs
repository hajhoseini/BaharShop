using BaharShop.Domain.Entities.Cities;
using BaharShop.Domain.IReaders.Cities;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Readers.Cities
{
    public class CityReader : GenericReader<City>, ICityReader
    {
        public CityReader(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}