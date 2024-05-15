using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Customers;
using BaharShop.Application.DTOs.Customers;
using BaharShop.Application.Features.Customers.Queries.Requests;

namespace BaharShop.Application.Features.Customers.Queries.RequestHandlers
{
    public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, CustomerDTO>
    {
        private readonly IMapper _mapper;
        private readonly ICustomerReader _customerReader;

        public GetCustomerQueryHandler(IMapper mapper, ICustomerReader customerReader)
        {
            _mapper = mapper;
            _customerReader = customerReader;
        }

        public async Task<CustomerDTO> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            var customerEntity = await _customerReader.GetById(request.Id);
            return _mapper.Map<CustomerDTO>(customerEntity);
        }
    }
}
