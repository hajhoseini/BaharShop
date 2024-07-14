using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.InfraStructure.DBContext;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BaharShop.InfraStructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly BaharShopDBContext _dbContext;

        public GenericRepository(BaharShopDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ResultDTO> Create(T entity)
        {
            var result = new ResultDTO();

            try
            {
                await _dbContext.Set<T>().AddAsync(entity);
                await _dbContext.SaveChangesAsync(CancellationToken.None);

                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = ex.Message;
            }
            
            return result;
        }

        public async Task<ResultDTO> Update(T entity)
        {
            var result = new ResultDTO();

            try
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync(CancellationToken.None);

                result.IsSuccess = true;
            }
            catch(Exception ex)
            {
                result.IsSuccess = false;
                result.Message = ex.Message;
            }
            
            return result;
        }

        public async Task<ResultDTO> Delete(T entity)
        {
            var result = new ResultDTO();

            try
            {
                _dbContext.Set<T>().Remove(entity);
                _dbContext.SaveChangesAsync(CancellationToken.None);

                result.IsSuccess = true;
            }
            catch(Exception ex)
            {
                result.IsSuccess = false;
                result.Message = ex.Message;
            }
            
            return result;
        }
    }
}
