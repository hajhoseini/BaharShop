using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.OrderItems;
using BaharShop.Application.DTOs.OrderItems;
using BaharShop.Application.Features.OrderItems.Queries.Requests;

namespace BaharShop.Application.Features.OrderItems.Queries.RequestHandlers
{
    public class GetOrderItemQueryHandler : IRequestHandler<GetOrderItemQuery, OrderItemDTO>
    {
        private readonly IMapper _mapper;
        private readonly IOrderItemReader _orderItemReader;

        public GetOrderItemQueryHandler(IMapper mapper, IOrderItemReader orderItemReader)
        {
            _mapper = mapper;
            _orderItemReader = orderItemReader;
        }

        public async Task<OrderItemDTO> Handle(GetOrderItemQuery request, CancellationToken cancellationToken)
        {
            var orderItemEntity = await _orderItemReader.GetById(request.Id);
            return _mapper.Map<OrderItemDTO>(orderItemEntity);
        }
    }
}
