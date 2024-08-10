using BaharShop.Application.DTOs.Carts;
using BaharShop.Common;

namespace BaharShop.Application.Services.Carts
{
    public interface ICartServices
    {
        Task<ResultDTO<CartDTO>> GetMyCart(Guid browserId);

        Task<ResultDTO> AddToCart(int productId, Guid browserId);

        Task<ResultDTO> RemoveFromCart(Guid browserId);

        Task<ResultDTO> Increase(int cartItemId);

        Task<ResultDTO> Decrease(int cartItemId);
    }
}
