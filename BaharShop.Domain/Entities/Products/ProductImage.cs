using BaharShop.Domain.Entities.Base;

namespace BaharShop.Domain.Entities.Products
{
    public class ProductImage : BaseEntity
    {
        public string Src { get; set; }

        public virtual Product Product { get; set; }

        public int ProductId { get; set; }        
    }
}
