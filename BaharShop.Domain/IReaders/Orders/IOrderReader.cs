using BaharShop.Common;
using BaharShop.Common.Enums;
using BaharShop.Domain.Entities.Orders;

namespace BaharShop.Domain.IReaders.Orders
{
    public interface IOrderReader : IGenericReader<Order>
    {
        List<Order> GetUserOrders(int userId);

        List<Order> GetListOrdersForAdmin(OrderState orderState);
    }
}