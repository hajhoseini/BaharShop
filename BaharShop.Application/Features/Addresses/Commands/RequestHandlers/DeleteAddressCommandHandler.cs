using MediatR;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Addresses;
using BaharShop.Application.Features.Addresses.Commands.Requests;

namespace BaharShop.Application.Features.Addresses.Commands.RequestHandlers
{
    public class DeleteAddressCommandHandler : IRequestHandler<DeleteAddressCommand, ResultDTO>
	{
		private readonly IGenericRepository<Address> _genericRepository;

		public DeleteAddressCommandHandler(IGenericRepository<Address> genericRepository)
		{
			_genericRepository = genericRepository;
		}

        public async Task<ResultDTO> Handle(DeleteAddressCommand request, CancellationToken cancellationToken)
        {
            Address address = new Address { Id = request.Id };
            var result = await _genericRepository.Delete(address);
            return result;
        }
    }
}
