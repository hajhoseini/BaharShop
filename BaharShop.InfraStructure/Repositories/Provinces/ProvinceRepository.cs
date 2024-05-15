using BaharShop.Domain.Entities.Provinces;
using BaharShop.Domain.IRepositories.Provinces;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Repositories.Provinces
{
    public class ProvinceRepository : GenericRepository<Province>, IProvinceRepository
    {
        public ProvinceRepository(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}
