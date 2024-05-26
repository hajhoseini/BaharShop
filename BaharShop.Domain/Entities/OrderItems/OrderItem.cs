using BaharShop.Domain.Entities.Base;
using System.ComponentModel;

namespace BaharShop.Domain.Entities.OrderItems
{
    public class OrderItem : BaseEntity
    {
        [Description("شناسه سفارش")]
        public int OrderId { get; set; }

        [Description("عنوان")]
        public string Title { get; set; }

        [Description("تعداد")]
        public int Count { get; set; }

        [Description("قیمت")]
        public decimal Price { get; set; }
    }
}
