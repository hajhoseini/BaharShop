using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Customers;
using BaharShop.Application.DTOs.Customers;
using BaharShop.Application.Features.Customers.Queries.Requests;

namespace BaharShop.Application.Features.Customers.Queries.RequestHandlers
{
    public class GetListCustomersQueryHandler : IRequestHandler<GetListCustomersQuery, List<CustomerDTO>>
	{
		private readonly IMapper _mapper;
		private readonly ICustomerReader _CustomerReader;

		public GetListCustomersQueryHandler(IMapper mapper, ICustomerReader CustomerReader)
		{
			_CustomerReader = CustomerReader;
		}

		public async Task<List<CustomerDTO>> Handle(GetListCustomersQuery request, CancellationToken cancellationToken)
		{
			var all = await _CustomerReader.GetList(null, null);
			return _mapper.Map<List<CustomerDTO>>(all.ToList());
		}
	}
}