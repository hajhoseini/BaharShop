using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.OrderItems;
using BaharShop.Application.Features.OrderItems.Commands.Requests;

namespace BaharShop.Application.Features.OrderItems.Commands.RequestHandlers
{
    public class UpdateOrderItemCommandHandler : IRequestHandler<UpdateOrderItemCommand, ResultDTO>
	{
		private readonly IGenericRepository<OrderItem> _genericRepository;
		private readonly IMapper _mapper;

		public UpdateOrderItemCommandHandler(IGenericRepository<OrderItem> genericRepository, IMapper mapper)
		{
			_genericRepository = genericRepository;
			_mapper = mapper;
		}

        public async Task<ResultDTO> Handle(UpdateOrderItemCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<OrderItem>(request.orderItemDTO);
            var result = await _genericRepository.Update(entity);
            return result;
        }
    }
}
