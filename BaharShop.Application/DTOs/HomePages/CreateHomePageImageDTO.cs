using BaharShop.Common.Enums;
using Microsoft.AspNetCore.Http;

namespace BaharShop.Application.DTOs.HomePages
{
    public class CreateHomePageImageDTO
    {
        public IFormFile File { get; set; }

        public string Link { get; set; }

        public ImageLocationEnum ImageLocation { get; set; }
    }
}
