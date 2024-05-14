using BaharShop.Domain.Entities.Base;

namespace BaharShop.Domain.Entities.Products
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
    }
}
