using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Customers;
using BaharShop.Application.Features.Customers.Commands.Requests;

namespace BaharShop.Application.Features.Customers.Commands.RequestHandlers
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, ResultDTO>
	{
		private readonly IGenericRepository<Customer> _genericRepository;
		private readonly IMapper _mapper;

		public UpdateCustomerCommandHandler(IGenericRepository<Customer> genericRepository, IMapper mapper)
		{
			_genericRepository = genericRepository;
			_mapper = mapper;
		}

        public async Task<ResultDTO> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Customer>(request.customerDTO);
            var result = await _genericRepository.Update(entity);
            return result;
        }
    }
}
