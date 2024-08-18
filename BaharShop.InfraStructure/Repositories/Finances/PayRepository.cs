using BaharShop.Domain.Entities.Finances;
using BaharShop.Domain.IRepositories.Finances;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Repositories.Finances
{
    public class PayRepository : GenericRepository<Pay>, IPayRepository
    {
        public PayRepository(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}