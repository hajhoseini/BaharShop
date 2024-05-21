using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Orders;
using BaharShop.Application.Features.Orders.Commands.Requests;

namespace BaharShop.Application.Features.Orders.Commands.RequestHandlers
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, ResultDTO>
	{
		private readonly IGenericRepository<Order> _genericRepository;
		private readonly IMapper _mapper;

		public CreateOrderCommandHandler(IGenericRepository<Order> genericRepository, IMapper mapper)
		{
			_genericRepository = genericRepository;
			_mapper = mapper;
		}

        public async Task<ResultDTO> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Order>(request.orderDTO);
            var result = await _genericRepository.Create(entity);
            return result;
        }
    }
}
