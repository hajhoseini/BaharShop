using BaharShop.Domain.Entities.Orders;
using BaharShop.Domain.IRepositories.Orders;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Repositories.Orders
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}