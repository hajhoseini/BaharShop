using MediatR;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Orders;
using BaharShop.Application.Features.Orders.Commands.Requests;

namespace BaharShop.Application.Features.Orders.Commands.RequestHandlers
{
    public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand, ResultDTO>
	{
		private readonly IGenericRepository<Order> _genericRepository;

		public DeleteOrderCommandHandler(IGenericRepository<Order> genericRepository)
		{
			_genericRepository = genericRepository;
		}

        public async Task<ResultDTO> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            Order order = new Order { Id = request.Id };
            var result = await _genericRepository.Delete(order);
            return result;
        }
    }
}
