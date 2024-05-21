using BaharShop.Domain.Entities.Base;

namespace BaharShop.Domain.Entities.Categories
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
    }
}
