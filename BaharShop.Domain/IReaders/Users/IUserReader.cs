using BaharShop.Domain.Entities.Users;

namespace BaharShop.Domain.IReaders.Users
{
    public interface IUserReader : IGenericReader<User>
    {
        List<User> GetListUsersInAdminPanel(int currentPage, int pageSize, out int rowCount);

        Task<User> GetByUserName(string UserName);
    }
}