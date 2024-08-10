using BaharShop.Domain.Entities.CartItems;
using BaharShop.Domain.IReaders.CartItems;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Readers.CartItems
{
    public class CartItemReader : GenericReader<CartItem>, ICartItemReader
    {
        public CartItemReader(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}
