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
		private readonly ICustomerReader _customerReader;

		public GetListCustomersQueryHandler(IMapper mapper, ICustomerReader customerReader)
		{
			_mapper = mapper;
			_customerReader = customerReader;
		}

		public async Task<List<CustomerDTO>> Handle(GetListCustomersQuery request, CancellationToken cancellationToken)
		{
			var all = await _customerReader.GetList(null, null);
			return _mapper.Map<List<CustomerDTO>>(all.ToList());
		}
	}
}