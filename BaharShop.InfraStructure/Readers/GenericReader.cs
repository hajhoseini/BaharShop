using BaharShop.Domain.IReaders;
using BaharShop.InfraStructure.DBContext;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BaharShop.InfraStructure.Readers
{
    public class GenericReader<T> : IGenericReader<T> where T : class
    {
        private readonly BaharShopDBContext _dbContext;

        public GenericReader(BaharShopDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> GetById(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<T> GetById(int id, string include)
        {
            var keyProperty = _dbContext.Model.FindEntityType(typeof(T)).FindPrimaryKey().Properties[0];
            if (string.IsNullOrEmpty(include))
                return await _dbContext.Set<T>().FindAsync(id);
            else
                return await _dbContext.Set<T>().Include(include).FirstOrDefaultAsync(e => EF.Property<int>(e, keyProperty.Name) == id);
        }

        public async Task<IReadOnlyList<T>> GetList(Expression<Func<T, bool>>? whereVariable = null, string join = "")
        {
            var all = _dbContext.Set<T>().AsQueryable().AsNoTracking();
            if (whereVariable != null)
            {
                all = all.Where(whereVariable);
            }

            if (!string.IsNullOrEmpty(join))
            {
                foreach (var j in join.Split(','))
                {
                    all = all.Include(j);
                }
            }

            var result = await all.ToListAsync();
            return result;
        }
    }
}
