using MediatR;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Customers;
using BaharShop.Application.Features.Customers.Commands.Requests;

namespace BaharShop.Application.Features.Customers.Commands.RequestHandlers
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand, ResultDTO>
	{
		private readonly IGenericRepository<Customer> _genericRepository;

		public DeleteCustomerCommandHandler(IGenericRepository<Customer> genericRepository)
		{
			_genericRepository = genericRepository;
		}

        public async Task<ResultDTO> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            Customer customer = new Customer { Id = request.Id };
            var result = await _genericRepository.Delete(customer);
            return result;
        }
    }
}
