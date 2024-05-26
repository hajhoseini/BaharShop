using System.ComponentModel;

namespace BaharShop.Application.DTOs.OrderItems
{
    public class OrderItemDTO
    {
        public int Id { get; set; }

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
