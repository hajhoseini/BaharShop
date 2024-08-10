namespace BaharShop.Application.DTOs.CartItems
{
    public class CartItemDTO
    {
        public long Id { get; set; }

        public string Product { get; set; }

        public string Images { get; set; }

        public int Count { get; set; }

        public decimal Price { get; set; }
    }
}