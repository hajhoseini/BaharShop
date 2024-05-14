using BaharShop.Domain.Entities.Base;

namespace BaharShop.Domain.Entities.Categories
{
    public class Category : BaseEntity
    {
        public int Name { get; set; }
        public int? ParentId { get; set; }
    }
}
