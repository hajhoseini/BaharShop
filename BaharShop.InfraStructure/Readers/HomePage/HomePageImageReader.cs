using BaharShop.Domain.Entities.HomePage;
using BaharShop.Domain.IReaders.HomePage;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Readers.HomePage
{
    public class HomePageImageReader : GenericReader<HomePageImage>, IHomePageImageReader
    {
        public HomePageImageReader(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}
