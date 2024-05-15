using BaharShop.Domain.Entities.Cities;
using BaharShop.Domain.IRepositories.Cities;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Repositories.Cities
{
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        public CityRepository(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}