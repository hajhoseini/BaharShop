using BaharShop.Domain.Entities.Base;
using BaharShop.Domain.Entities.Orders;
using BaharShop.Domain.Entities.Products;

namespace BaharShop.Domain.Entities.OrderItems
{
    public class OrderItem : BaseEntity
    {
        public virtual Order Order { get; set; }

        public int OrderId { get; set; }

        public virtual Product Product { get; set; }

        public int ProductId { get; set; }

        public decimal Price { get; set; }

        public int Count { get; set; }
    }
}
