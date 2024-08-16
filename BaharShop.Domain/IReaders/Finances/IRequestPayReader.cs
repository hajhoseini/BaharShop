using BaharShop.Domain.Entities.Finances;

namespace BaharShop.Domain.IReaders.Finances
{
    public interface IRequestPayReader : IGenericReader<RequestPay>
    {
        Task<RequestPay> GetByGuid(Guid guid);

        Task<List<RequestPay>> GetListForAdmin();
    }
}
