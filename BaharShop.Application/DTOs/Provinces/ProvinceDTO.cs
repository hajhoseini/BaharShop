using System.ComponentModel;

namespace BaharShop.Application.DTOs.Provinces
{
    public class ProvinceDTO
    {
        public int Id { get; set; }

        [Description("نام استان")]
        public string Name { get; set; }
    }
}