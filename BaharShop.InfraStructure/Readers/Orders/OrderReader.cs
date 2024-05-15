using BaharShop.Domain.Entities.Orders;
using BaharShop.Domain.IReaders.Orders;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Readers.Orders
{
    public class OrderReader : GenericReader<Order>, IOrderReader
    {
        public OrderReader(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}