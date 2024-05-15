using BaharShop.Domain.Entities.OrderItems;
using BaharShop.Domain.IRepositories.OrderItems;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Repositories.OrderItems
{
    public class OrderItemRepository : GenericRepository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}