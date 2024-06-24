using BaharShop.Domain.Entities.Roles;
using BaharShop.Domain.IRepositories.Roles;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Repositories.Roles
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}