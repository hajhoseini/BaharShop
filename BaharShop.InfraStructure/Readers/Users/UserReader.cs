using BaharShop.Domain.Entities.Users;
using BaharShop.Domain.IReaders.Users;
using BaharShop.InfraStructure.DBContext;
using BaharShop.Common;

namespace BaharShop.InfraStructure.Readers.Users
{
    public class UserReader : GenericReader<User>, IUserReader
    {
        private readonly BaharShopDBContext _dbContext;

        public UserReader(BaharShopDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public List<User> GetListUsersInAdminPanel(int page, int pageSize, out int rowCount)
        {
            var Users = _dbContext.User
                .ToPaged(page, pageSize, out rowCount)
                .ToList();

            return Users;
        }
    }
}