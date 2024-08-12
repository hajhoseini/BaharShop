using BaharShop.Domain.Entities.Finances;
using BaharShop.Domain.IReaders.Finances;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Readers.Finances
{
    public class RequestPayReader : GenericReader<RequestPay>, IRequestPayReader
    {
        private readonly BaharShopDBContext _dbContext;

        public RequestPayReader(BaharShopDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<RequestPay> GetByGuid(Guid guid)
        {
            var requestPay = _dbContext.RequestPay.Where(p => p.Guid == guid).FirstOrDefault();
            return requestPay;
        }
    }
}