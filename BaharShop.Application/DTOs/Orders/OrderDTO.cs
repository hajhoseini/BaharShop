using BaharShop.Common.Enums;

namespace BaharShop.Application.DTOs.Orders
{
    public class OrderDTO
    {
        public int OrderId { get; set; }

        public DateTime InsertDate { get; set; }

        public int RequestId { get; set; }

        public int UserId { get; set; }

        public OrderState OrderState { get; set; }

        public int ProductCount { get; set; }
    }
}
