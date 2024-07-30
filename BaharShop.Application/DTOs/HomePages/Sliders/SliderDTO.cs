using Microsoft.AspNetCore.Http;

namespace BaharShop.Application.DTOs.HomePages.Sliders
{
    public class SliderDTO
    {
        public int Id { get; set; }

        public IFormFile File { get; set; }

        public string Link { get; set; }
    }
}
