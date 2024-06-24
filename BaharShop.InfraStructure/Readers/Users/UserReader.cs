using BaharShop.Domain.Entities.Users;
using BaharShop.Domain.IReaders.Users;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Readers.Users
{
    public class UserReader : GenericReader<User>, IUserReader
    {
        public UserReader(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}