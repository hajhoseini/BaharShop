using BaharShop.Domain.Entities.Products;
using BaharShop.Domain.IReaders.Products;
using BaharShop.InfraStructure.DBContext;
using Microsoft.EntityFrameworkCore;
using BaharShop.Common;
using BaharShop.Common.Enums;

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

        public List<Product> GetListProductsSite(int page, int pageSize, out int totalRow, int? categoryId, string searchKey, ProductOrderingEnum ordering)
        {
            var productsQuery = _dbContext.Product
                    .Include(p => p.ProductImages)
                    .AsQueryable();

            if (categoryId != null)
            {
                productsQuery = productsQuery.Where(p => p.CategoryId == categoryId || p.Category.ParentId == categoryId).AsQueryable();
            }

            if (!string.IsNullOrWhiteSpace(searchKey))
            {
                productsQuery = productsQuery.Where(p => p.Title.Contains(searchKey) /*|| p.Brand.Contains(searchKey)*/).AsQueryable();
            }

            switch (ordering)
            {
                case ProductOrderingEnum.NotOrder:
                    productsQuery = productsQuery.OrderByDescending(p => p.Id).AsQueryable();
                    break;
                case ProductOrderingEnum.MostVisited:
                    break;
                case ProductOrderingEnum.BestSelling:
                    break;
                case ProductOrderingEnum.MostPopular:
                    break;
                case ProductOrderingEnum.TheNewest:
                    productsQuery = productsQuery.OrderByDescending(p => p.Id).AsQueryable();
                    break;
                case ProductOrderingEnum.Cheapest:
                    productsQuery = productsQuery.OrderBy(p => p.Price).AsQueryable();
                    break;
                case ProductOrderingEnum.TheMostExpensive:
                    productsQuery = productsQuery.OrderByDescending(p => p.Price).AsQueryable();
                    break;
            }

            var products = productsQuery
                            .ToPaged(page, pageSize, out totalRow)
                            .ToList();

            return products;
        }

        public async Task<Product> GetProductDetail(int id)
        {
            var product = _dbContext.Product
                .Include(p => p.Category)
                .ThenInclude(p => p.ParentCategory)
                .Include(p => p.ProductImages)
                .Include(p => p.ProductFeatures)
                .Where(p => p.Id == id).FirstOrDefault();           

            if (product == null)
            {
                throw new Exception("Product Not Found.....");
            }

            //این کد باید به محل مناسب جابجا شود
            product.ViewCount++;
            _dbContext.SaveChanges();

            return product;
        }
    }
}