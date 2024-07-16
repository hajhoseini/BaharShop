using BaharShop.Domain.Entities.Products;
using BaharShop.Domain.IReaders.Products;
using BaharShop.InfraStructure.DBContext;
using Microsoft.EntityFrameworkCore;
using BaharShop.Common;

namespace BaharShop.InfraStructure.Readers.Products
{
    public class ProductReader : GenericReader<Product>, IProductReader
    {
        private readonly BaharShopDBContext _dbContext;

        public ProductReader(BaharShopDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Product> GetListProductsInAdminPanel(int page, int pageSize, out int rowCount)
        {
            var products = _dbContext.Product
                .Include(p => p.Category)
                .ToPaged(page, pageSize, out rowCount)
                .ToList();

            return products;
        }
    }
}