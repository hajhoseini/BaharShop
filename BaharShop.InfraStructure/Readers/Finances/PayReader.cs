using BaharShop.Domain.Entities.Finances;
using BaharShop.Domain.IReaders.Finances;
using BaharShop.InfraStructure.DBContext;
using Microsoft.EntityFrameworkCore;

namespace BaharShop.InfraStructure.Readers.Finances
{
    public class PayReader : GenericReader<Pay>, IPayReader
    {
        private readonly BaharShopDBContext _dbContext;

        public PayReader(BaharShopDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Pay> GetByGuid(Guid guid)
        {
            var pay = _dbContext.Pay.Where(p => p.Guid == guid).FirstOrDefault();
            return pay;
        }

        public async Task<List<Pay>> GetListForAdmin()
        {
            var pays = _dbContext.Pay
                .Include(p => p.User)
                .ToList();

            return pays;
        }
    }
}