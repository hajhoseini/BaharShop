using BaharShop.Domain.Entities.Users;
using BaharShop.Domain.IReaders.Users;
using BaharShop.InfraStructure.DBContext;
using BaharShop.Common;
using Microsoft.EntityFrameworkCore;

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

        public async Task<User> GetByUserName(string userName)
        {
            User user = _dbContext.User.Include(p => p.UserRoles).ThenInclude(p => p.Role).FirstOrDefault(x => x.Email == userName);
            return user;
        }
    }
}