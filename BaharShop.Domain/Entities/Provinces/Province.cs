using BaharShop.Domain.Entities.Base;
using System.ComponentModel;

namespace BaharShop.Domain.Entities.Provinces
{
    public class Province : BaseEntity
    {
        [Description("نام استان")]
        public string Name { get; set; }
    }
}
