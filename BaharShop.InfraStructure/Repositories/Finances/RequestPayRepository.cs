using BaharShop.Domain.Entities.Finances;
using BaharShop.Domain.IRepositories.Finances;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Repositories.Finances
{
    public class RequestPayRepository : GenericRepository<RequestPay>, IRequestPayRepository
    {
        public RequestPayRepository(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}