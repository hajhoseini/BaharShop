namespace BaharShop.Application.DTOs.Orders
{
    public class RequestCreateOrderDTO
    {
        public int CartId { get; set; }

        public int RequestPayId { get; set; }

        public int UserId { get; set; }

        public string Authority { get; set; }

        public long RefId { get; set; }
    }
}
