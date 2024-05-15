using BaharShop.Domain.Entities.Categories;
using BaharShop.Domain.IReaders.Categories;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Readers.Categories
{
    public class CategoryReader : GenericReader<Category>, ICategoryReader
    {
        public CategoryReader(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}