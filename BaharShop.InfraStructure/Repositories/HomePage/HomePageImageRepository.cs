using BaharShop.Domain.Entities.HomePage;
using BaharShop.Domain.IRepositories.HomePage;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Repositories.HomePage
{
    public class HomePageImageRepository : GenericRepository<HomePageImage>, IHomePageImageRepository
    {
        public HomePageImageRepository(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}
