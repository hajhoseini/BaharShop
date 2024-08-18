namespace BaharShop.Application.DTOs.Orders
{
    public class CreateOrderDTO
    {
        public int CartId { get; set; }

        public int PayId { get; set; }

        public int UserId { get; set; }

        public string Authority { get; set; }

        public long RefId { get; set; }
    }
}
