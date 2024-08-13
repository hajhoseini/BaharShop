using BaharShop.Common.Enums;
using BaharShop.Domain.Entities.Base;
using BaharShop.Domain.Entities.Finances;
using BaharShop.Domain.Entities.OrderItems;
using BaharShop.Domain.Entities.Users;

namespace BaharShop.Domain.Entities.Orders
{
    public class Order : BaseEntity
    {
        public virtual User User { get; set; }

        public int UserId { get; set; }

        public virtual RequestPay RequestPay { get; set; }

        public int RequestPayId { get; set; }

        public OrderState OrderState { get; set; }

        public string Address { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
