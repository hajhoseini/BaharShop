using BaharShop.Common;

namespace BaharShop.Domain.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<ResultDTO> Create(T entity);

        Task<ResultDTO> Update(T entity);

        Task<ResultDTO> Delete(T entity);

        Task<ResultDTO> AddRange(List<T> entities);
    }
}
