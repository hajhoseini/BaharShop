using BaharShop.Domain.Entities.Categories;
using BaharShop.Domain.IRepositories.Categories;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Repositories.Categories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}