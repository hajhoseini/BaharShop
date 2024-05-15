using BaharShop.Domain.Entities.OrderItems;
using BaharShop.Domain.IReaders.OrderItems;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Readers.OrderItems
{
    public class OrderItemReader : GenericReader<OrderItem>, IOrderItemReader
    {
        public OrderItemReader(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}