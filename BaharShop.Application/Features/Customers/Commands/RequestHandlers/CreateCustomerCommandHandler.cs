using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Customers;
using BaharShop.Application.Features.Customers.Commands.Requests;

namespace BaharShop.Application.Features.Customers.Commands.RequestHandlers
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, ResultDTO>
	{
		private readonly IGenericRepository<Customer> _genericRepository;
		private readonly IMapper _mapper;

		public CreateCustomerCommandHandler(IGenericRepository<Customer> genericRepository, IMapper mapper)
		{
			_genericRepository = genericRepository;
			_mapper = mapper;
		}

        public async Task<ResultDTO> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Customer>(request.customerDTO);
            var result = await _genericRepository.Create(entity);
            return result;
        }
    }
}
