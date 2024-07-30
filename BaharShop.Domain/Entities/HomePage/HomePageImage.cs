using BaharShop.Common.Enums;
using BaharShop.Domain.Entities.Base;

namespace BaharShop.Domain.Entities.HomePage
{
    public class HomePageImage : BaseEntity
    {
        public string Src { get; set; }

        public string Link { get; set; }

        public ImageLocationEnum ImageLocation { get; set; }
    }
}
