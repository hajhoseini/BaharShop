using BaharShop.Domain.Entities.Finances;

namespace BaharShop.Domain.IReaders.Finances
{
    public interface IPayReader : IGenericReader<Pay>
    {
        Task<Pay> GetByGuid(Guid guid);

        Task<List<Pay>> GetListForAdmin();
    }
}
