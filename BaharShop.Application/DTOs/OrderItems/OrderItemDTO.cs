namespace BaharShop.Application.DTOs.OrderItems
{
    public class OrderItemDTO
    {
        public int OrderItemId { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public int Count { get; set; }
    }
}
