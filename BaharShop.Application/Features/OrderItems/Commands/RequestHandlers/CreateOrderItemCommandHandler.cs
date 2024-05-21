using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.OrderItems;
using BaharShop.Application.Features.OrderItems.Commands.Requests;

namespace BaharShop.Application.Features.OrderItems.Commands.RequestHandlers
{
    public class CreateOrderItemCommandHandler : IRequestHandler<CreateOrderItemCommand, ResultDTO>
	{
		private readonly IGenericRepository<OrderItem> _genericRepository;
		private readonly IMapper _mapper;

		public CreateOrderItemCommandHandler(IGenericRepository<OrderItem> genericRepository, IMapper mapper)
		{
			_genericRepository = genericRepository;
			_mapper = mapper;
		}

        public async Task<ResultDTO> Handle(CreateOrderItemCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<OrderItem>(request.orderItemDTO);
            var result = await _genericRepository.Create(entity);
            return result;
        }
    }
}
