using BaharShop.Domain.Entities.UserRoles;
using BaharShop.Domain.IReaders.UserRoles;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Readers.UserRoles
{
    public class UserRoleReader : GenericReader<UserRole>, IUserRoleReader
    {
        public UserRoleReader(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}