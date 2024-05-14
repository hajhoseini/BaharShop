using BaharShop.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace BaharShop.Domain.Entities.Cities
{
    public class City : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int ProvinceId { get; set; }
    }
}
