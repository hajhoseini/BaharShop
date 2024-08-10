using BaharShop.Domain.Entities.CartItems;
using BaharShop.Domain.IRepositories.CartItems;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Repositories.CartItems
{
    public class CartItemRepository : GenericRepository<CartItem>, ICartItemRepository
    {
        public CartItemRepository(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}