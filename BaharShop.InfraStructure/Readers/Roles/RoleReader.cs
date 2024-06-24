using BaharShop.Domain.Entities.Roles;
using BaharShop.Domain.IReaders.Roles;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Readers.Roles
{
    public class RoleReader : GenericReader<Role>, IRoleReader
    {
        public RoleReader(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}