using BaharShop.Domain.Entities.Carts;

namespace BaharShop.Domain.IReaders.Carts
{
    public interface ICartReader : IGenericReader<Cart>
    {
        Task<Cart> GetMyCart(Guid browserId);
    }
}