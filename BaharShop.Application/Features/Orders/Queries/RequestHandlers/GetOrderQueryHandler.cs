using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Orders;
using BaharShop.Application.DTOs.Orders;
using BaharShop.Application.Features.Orders.Queries.Requests;

namespace BaharShop.Application.Features.Orders.Queries.RequestHandlers
{
    public class GetOrderQueryHandler : IRequestHandler<GetOrderQuery, OrderDTO>
    {
        private readonly IMapper _mapper;
        private readonly IOrderReader _orderReader;

        public GetOrderQueryHandler(IMapper mapper, IOrderReader orderReader)
        {
            _mapper = mapper;
            _orderReader = orderReader;
        }

        public async Task<OrderDTO> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            var orderEntity = await _orderReader.GetById(request.Id);
            return _mapper.Map<OrderDTO>(orderEntity);
        }
    }
}
