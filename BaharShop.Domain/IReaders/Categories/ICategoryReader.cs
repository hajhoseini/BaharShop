using BaharShop.Domain.Entities.Categories;

namespace BaharShop.Domain.IReaders.Categories
{
    public interface ICategoryReader : IGenericReader<Category>
    {
        Task<List<Category>> GetList();

        Task<List<Category>> GetListByParentId(int? parentId);

        Task<List<Category>> GetListMenuItems();

        Task<List<Category>> GetListLastLevel();
    }
}