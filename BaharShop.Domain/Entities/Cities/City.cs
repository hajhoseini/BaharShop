using BaharShop.Domain.Entities.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BaharShop.Domain.Entities.Cities
{
    public class City : BaseEntity
    {
        [Required]
        [Description("نام شهر")]
        public string Name { get; set; }

        [Required]
        [Description("استان")]
        public int ProvinceId { get; set; }
    }
}
