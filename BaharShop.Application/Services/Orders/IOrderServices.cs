using BaharShop.Application.DTOs.Orders;
using BaharShop.Common;

namespace BaharShop.Application.Services.Orders
{
    public interface IOrderServices
    {
        Task<ResultDTO> CreateOrder(RequestCreateOrderDTO request);
    }
}
