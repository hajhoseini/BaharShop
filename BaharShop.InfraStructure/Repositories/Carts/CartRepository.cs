using BaharShop.Domain.Entities.Carts;
using BaharShop.Domain.IRepositories.Carts;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Repositories.Carts
{
    public class CartRepository : GenericRepository<Cart>, ICartRepository
    {
        public CartRepository(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}