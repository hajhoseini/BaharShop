using BaharShop.Domain.Entities.HomePages.Sliders;
using BaharShop.Domain.IReaders.HomePages.Sliders;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Readers.HomePages.Sliders
{
    public class SliderReader : GenericReader<Slider>, ISliderReader
    {
        public SliderReader(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}