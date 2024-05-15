using System.Linq.Expressions;

namespace BaharShop.Domain.IReaders
{
    public interface IGenericReader<T> where T : class
    {
        Task<T> GetById(int id);

        Task<T> GetById(int id, string include);

        Task<IReadOnlyList<T>> GetList(Expression<Func<T, bool>>? whereVariable = null, string join = "");
    }
}