using BaharShop.Common.Enums;

namespace BaharShop.Application.DTOs.HomePages
{
    public class HomePageImageDTO
    {
        public int Id { get; set; }

        public string Src { get; set; }

        public string Link { get; set; }

        public ImageLocationEnum ImageLocation { get; set; }
    }
}
