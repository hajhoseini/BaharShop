using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Orders;
using BaharShop.Application.DTOs.Orders;
using BaharShop.Application.Features.Orders.Queries.Requests;

namespace BaharShop.Application.Features.Orders.Queries.RequestHandlers
{
    public class GetListOrdersQueryHandler : IRequestHandler<GetListOrdersQuery, List<OrderDTO>>
	{
		private readonly IMapper _mapper;
		private readonly IOrderReader _orderReader;

		public GetListOrdersQueryHandler(IMapper mapper, IOrderReader orderReader)
		{
			_mapper = mapper;
			_orderReader = orderReader;
		}

		public async Task<List<OrderDTO>> Handle(GetListOrdersQuery request, CancellationToken cancellationToken)
		{
			var all = await _orderReader.GetList(null, null);
			return _mapper.Map<List<OrderDTO>>(all.ToList());
		}
	}
}