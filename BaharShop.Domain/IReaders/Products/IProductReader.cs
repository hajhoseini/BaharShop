using BaharShop.Domain.Entities.Products;

namespace BaharShop.Domain.IReaders.Products
{
    public interface IProductReader : IGenericReader<Product>
    {
        List<Product> GetListProductsInAdminPanel(int currentPage, int pageSize, out int rowCount);

        List<Product> GetListProductsSite(int page, out int totalRow, int? categoryId, string searchKey);

        Task<Product> GetProductDetail(int id); 
    }
}