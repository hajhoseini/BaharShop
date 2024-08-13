using BaharShop.Application.DTOs.OrderItems;
using BaharShop.Application.DTOs.Orders;
using BaharShop.Common;
using BaharShop.Common.Enums;
using BaharShop.Domain.Entities.Carts;
using BaharShop.Domain.Entities.Finances;
using BaharShop.Domain.Entities.OrderItems;
using BaharShop.Domain.Entities.Orders;
using BaharShop.Domain.Entities.Users;
using BaharShop.Domain.IReaders;
using BaharShop.Domain.IReaders.Orders;
using BaharShop.Domain.IRepositories;

namespace BaharShop.Application.Services.Orders
{
    public class OrderServices : IOrderServices
    {
        private readonly IGenericReader<User> _userReader;
        private readonly IGenericReader<RequestPay> _requestPayReader;
        private readonly IGenericReader<Cart> _cartReader;

        private readonly IGenericRepository<Order> _orderRepository;
        private readonly IGenericRepository<OrderItem> _orderItemRepository;

        private readonly IOrderReader _orderReader;

        public OrderServices(IGenericReader<User> userReader
                                , IGenericReader<RequestPay> requestPayReader
                                , IGenericReader<Cart> cartReader
                                , IGenericRepository<Order> orderRepository
                                , IGenericRepository<OrderItem> orderItemRepository
                                , IOrderReader orderReader)
        {
            _userReader = userReader;
            _requestPayReader = requestPayReader;
            _cartReader = cartReader;
            _orderRepository = orderRepository;
            _orderItemRepository = orderItemRepository;
            _orderReader = orderReader;
        }

        public async Task<ResultDTO> CreateOrder(RequestCreateOrderDTO request)
        {
            var user = await _userReader.GetById(request.UserId);
            var requestPay = await _requestPayReader.GetById(request.RequestPayId);
            //var cart = _context.Carts.Include(p => p.CartItems)
            //    .ThenInclude(p => p.Product)
            //    .Where(p => p.Id == request.CartId).FirstOrDefault();
            var cart = await _cartReader.GetById(request.CartId);

            requestPay.IsPay = true;
            requestPay.PayDate = DateTime.Now;

            cart.Finished = true;

            Order order = new Order()
            {
                Address = "",
                OrderState = OrderState.Processing,
                RequestPay = requestPay,
                User = user,
            };
            var orderResult = await _orderRepository.Create(order);

            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (var item in cart.CartItems)
            {
                OrderItem orderItem = new OrderItem()
                {
                    Count = item.Count,
                    Order = order,
                    Price = item.Product.Price,
                    Product = item.Product,
                };
                orderItems.Add(orderItem);
            }

            await _orderItemRepository.AddRange(orderItems);

            return new ResultDTO()
            {
                IsSuccess = true,
                Message = "",
            };
        }

        public ResultDTO<List<GetUserOrderDTO>> GetUserOrders(int userId)
        {
            var orders = _orderReader.GetUserOrders(userId).Select(p => new GetUserOrderDTO
                                                            {
                                                                OrderId = p.Id,
                                                                OrderState = p.OrderState,
                                                                RequestPayId = p.RequestPayId,
                                                                OrderItems = p.OrderItems.Select(o => new OrderItemDTO
                                                                {
                                                                    Count = o.Count,
                                                                    OrderItemId = o.Id,
                                                                    Price = o.Price,
                                                                    ProductId = o.ProductId,
                                                                    ProductName = o.Product.Title,
                                                                }).ToList(),
                                                            }).ToList();

            return new ResultDTO<List<GetUserOrderDTO>>()
            {
                Data = orders,
                IsSuccess = true,
            };
        }
    }
}
