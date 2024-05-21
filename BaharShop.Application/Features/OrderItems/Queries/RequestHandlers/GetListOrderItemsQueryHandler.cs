using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.OrderItems;
using BaharShop.Application.DTOs.OrderItems;
using BaharShop.Application.Features.OrderItems.Queries.Requests;

namespace BaharShop.Application.Features.OrderItems.Queries.RequestHandlers
{
    public class GetListOrderItemsQueryHandler : IRequestHandler<GetListOrderItemsQuery, List<OrderItemDTO>>
	{
		private readonly IMapper _mapper;
		private readonly IOrderItemReader _orderItemReader;

		public GetListOrderItemsQueryHandler(IMapper mapper, IOrderItemReader orderItemReader)
		{
			_mapper = mapper;
			_orderItemReader = orderItemReader;
		}

		public async Task<List<OrderItemDTO>> Handle(GetListOrderItemsQuery request, CancellationToken cancellationToken)
		{
			var all = await _orderItemReader.GetList(null, null);
			return _mapper.Map<List<OrderItemDTO>>(all.ToList());
		}
	}
}