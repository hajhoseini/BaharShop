using MediatR;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.OrderItems;
using BaharShop.Application.Features.OrderItems.Commands.Requests;

namespace BaharShop.Application.Features.OrderItems.Commands.RequestHandlers
{
    public class DeleteOrderItemCommandHandler : IRequestHandler<DeleteOrderItemCommand, ResultDTO>
	{
		private readonly IGenericRepository<OrderItem> _genericRepository;

		public DeleteOrderItemCommandHandler(IGenericRepository<OrderItem> genericRepository)
		{
			_genericRepository = genericRepository;
		}

        public async Task<ResultDTO> Handle(DeleteOrderItemCommand request, CancellationToken cancellationToken)
        {
            OrderItem orderItem = new OrderItem { Id = request.Id };
            var result = await _genericRepository.Delete(orderItem);
            return result;
        }
    }
}
