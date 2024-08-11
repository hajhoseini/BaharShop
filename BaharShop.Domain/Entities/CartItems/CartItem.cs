using BaharShop.Domain.Entities.Base;
using BaharShop.Domain.Entities.Carts;
using BaharShop.Domain.Entities.Products;

namespace BaharShop.Domain.Entities.CartItems
{
    public class CartItem : BaseEntity
    {
        public virtual Product Product { get; set; }

        public int ProductId { get; set; }

        public int Count { get; set; }

        public decimal Price { get; set; }

        public virtual Cart Cart { get; set; }

        public int CartId { get; set; }
    }
}
