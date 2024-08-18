using BaharShop.Application.DTOs.OrderItems;
using BaharShop.Common.Enums;

namespace BaharShop.Application.DTOs.Orders
{
    public class GetUserOrderDTO
    {
        public int OrderId { get; set; }

        public OrderState OrderState { get; set; }

        public int PayId { get; set; }

        public List<OrderItemDTO> OrderItems { get; set; }
    }
}
