using BaharShop.Domain.Entities.Categories;

namespace BaharShop.Domain.IReaders.Categories
{
    public interface ICategoryReader : IGenericReader<Category>
    {
        Task<List<Category>> GetList();
    }
}