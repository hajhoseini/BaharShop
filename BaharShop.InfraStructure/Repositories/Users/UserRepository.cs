using BaharShop.Common;
using BaharShop.Domain.Entities.Users;
using BaharShop.Domain.IRepositories.Users;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Repositories.Users
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly BaharShopDBContext _dbContext;

        public UserRepository(BaharShopDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ResultDTO<User>> Register(User entity)
        {
            var result = new ResultDTO<User>();

            try
            {
                entity.InsertDate = DateTime.Now;

                await _dbContext.AddAsync(entity);
                await _dbContext.SaveChangesAsync(CancellationToken.None);

                result.Data = entity;
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = ex.Message;
            }

            return result;
        }
    }
}
