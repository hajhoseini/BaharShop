using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Orders;
using BaharShop.Application.Features.Orders.Commands.Requests;

namespace BaharShop.Application.Features.Orders.Commands.RequestHandlers
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand, ResultDTO>
	{
		private readonly IGenericRepository<Order> _genericRepository;
		private readonly IMapper _mapper;

		public UpdateOrderCommandHandler(IGenericRepository<Order> genericRepository, IMapper mapper)
		{
			_genericRepository = genericRepository;
			_mapper = mapper;
		}

        public async Task<ResultDTO> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Order>(request.OrderDTO);
            var result = await _genericRepository.Update(entity);
            return result;
        }
    }
}
