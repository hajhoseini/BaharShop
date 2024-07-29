using BaharShop.Domain.Entities.HomePages.Sliders;
using BaharShop.Domain.IRepositories.HomePages.Sliders;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Repositories.HomePages.Sliders
{
    public class SliderRepository : GenericRepository<Slider>, ISliderRepository
    {
        public SliderRepository(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}