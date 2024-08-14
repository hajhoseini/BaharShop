using BaharShop.Common;
using BaharShop.Common.Enums;
using BaharShop.Domain.Entities.Orders;
using BaharShop.Domain.IReaders.Orders;
using BaharShop.InfraStructure.DBContext;
using Microsoft.EntityFrameworkCore;

namespace BaharShop.InfraStructure.Readers.Orders
{
    public class OrderReader : GenericReader<Order>, IOrderReader
    {
        private readonly BaharShopDBContext _dbContext;

        public OrderReader(BaharShopDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Order> GetUserOrders(int userId)
        {
            var orders = _dbContext.Order
                                .Include(p => p.OrderItems)
                                .ThenInclude(p => p.Product)
                                .Where(p => p.UserId == userId)
                                .OrderByDescending(p => p.Id).ToList();

            return orders;
        }

        public List<Order> GetListOrdersForAdmin(OrderState orderState)
        {
            var orders = _dbContext.Order
                                 .Include(p => p.OrderItems)
                                 .Where(p => p.OrderState == orderState)
                                 .OrderByDescending(p => p.Id)
                                 .ToList();                                 

            return orders;
        }
    }
}