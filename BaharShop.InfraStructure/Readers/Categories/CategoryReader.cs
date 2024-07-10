using BaharShop.Domain.Entities.Categories;
using BaharShop.Domain.IReaders.Categories;
using BaharShop.InfraStructure.DBContext;
using Microsoft.EntityFrameworkCore;

namespace BaharShop.InfraStructure.Readers.Categories
{
    public class CategoryReader : GenericReader<Category>, ICategoryReader
    {
        private readonly BaharShopDBContext _dbContext;

        public CategoryReader(BaharShopDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Category>> GetList()
        {
            var all = _dbContext.Category.ToList();
            return all;
        }

        public async Task<List<Category>> GetListByParentId(int? parentId)
        {
            var categories = _dbContext.Category
               .Include(p => p.Children)
               .Where(p => p.ParentId == parentId)
               .ToList();

            return categories;
        }
    }
}