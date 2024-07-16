using BaharShop.Domain.Entities.Products;

namespace BaharShop.Domain.IReaders.Products
{
    public interface IProductReader : IGenericReader<Product>
    {
        List<Product> GetListProductsInAdminPanel();
    }
}