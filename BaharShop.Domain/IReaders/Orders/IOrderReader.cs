using BaharShop.Domain.Entities.Orders;

namespace BaharShop.Domain.IReaders.Orders
{
    public interface IOrderReader : IGenericReader<Order>
    {
        List<Order> GetUserOrders(int userId);
    }
}