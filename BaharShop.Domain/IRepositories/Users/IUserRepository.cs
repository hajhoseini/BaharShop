using BaharShop.Common;
using BaharShop.Domain.Entities.Users;

namespace BaharShop.Domain.IRepositories.Users
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<ResultDTO> Register(User entity);
    }
}
