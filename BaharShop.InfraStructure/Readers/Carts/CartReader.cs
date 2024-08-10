using BaharShop.Domain.Entities.Carts;
using BaharShop.Domain.IReaders.Carts;
using BaharShop.InfraStructure.DBContext;
using Microsoft.EntityFrameworkCore;

namespace BaharShop.InfraStructure.Readers.Carts
{
    public class CartReader : GenericReader<Cart>, ICartReader
    {
        private readonly BaharShopDBContext _dbContext;

        public CartReader(BaharShopDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Cart> GetMyCart(Guid browserId)
        {
            var cart = _dbContext.Cart
                    .Include(p => p.CartItems)
                    .ThenInclude(p => p.Product)
                    .ThenInclude(p => p.ProductImages)
                    .Where(p => p.BrowserId == browserId && p.Finished == false)
                    .OrderByDescending(p => p.Id)
                    .FirstOrDefault();

            return cart;
        }
    }
}
