using System.ComponentModel;

namespace BaharShop.Application.DTOs.Cities
{
    public class CityDTO
    {
        public int Id { get; set; }

        [Description("نام شهر")]
        public string Name { get; set; }

        [Description("استان")]
        public int ProvinceId { get; set; }
    }
}
