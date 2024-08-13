using BaharShop.Application.DTOs.CartItems;

namespace BaharShop.Application.DTOs.Carts
{
    public class CartDTO
    {
        public int CartId { get; set; }

        public int ProductCount { get; set; }

        public decimal SumAmount { get; set; }

        public List<CartItemDTO> CartItems { get; set; }
    }
}
