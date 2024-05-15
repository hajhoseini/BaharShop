using BaharShop.Domain.Entities.Products;
using BaharShop.Domain.IRepositories.Products;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Repositories.Products
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}