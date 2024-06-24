using BaharShop.Domain.Entities.UserRoles;
using BaharShop.Domain.IRepositories.UserRoles;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Repositories.UserRoles
{
    public class UserRoleRepository : GenericRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}