using BaharShop.Domain.Entities.Users;
using BaharShop.Domain.IRepositories.Users;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Repositories.Users
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}