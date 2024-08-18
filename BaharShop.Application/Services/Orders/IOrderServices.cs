using BaharShop.Application.DTOs.Orders;
using BaharShop.Common;
using BaharShop.Common.Enums;

namespace BaharShop.Application.Services.Orders
{
    public interface IOrderServices
    {
        Task<ResultDTO> CreateOrder(CreateOrderDTO request);

        ResultDTO<List<GetUserOrderDTO>> GetUserOrders(int userId);

        ResultDTO<List<OrderDTO>> GetListOrdersForAdmin(OrderState orderState);
    }
}
