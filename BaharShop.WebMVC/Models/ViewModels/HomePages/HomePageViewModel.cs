using BaharShop.Application.DTOs.HomePages;

namespace BaharShop.WebMVC.Models.ViewModels.HomePages
{
    public class HomePageViewModel
    {
        public List<HomePageImageDTO> Sliders { get; set; }

        public List<HomePageImageDTO> PageImages { get; set; }
        //public List<ProductForSiteDto> Camera { get; set; }
        //public List<ProductForSiteDto> Mobile { get; set; }
        //public List<ProductForSiteDto> Laptop { get; set; }
    }
}
