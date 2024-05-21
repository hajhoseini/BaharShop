using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Addresses;
using BaharShop.Application.Features.Addresses.Commands.Requests;

namespace BaharShop.Application.Features.Addresses.Commands.RequestHandlers
{
    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommand, ResultDTO>
	{
		private readonly IGenericRepository<Address> _genericRepository;
		private readonly IMapper _mapper;

		public CreateAddressCommandHandler(IGenericRepository<Address> genericRepository, IMapper mapper)
		{
			_genericRepository = genericRepository;
			_mapper = mapper;
		}

        public async Task<ResultDTO> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Address>(request.addressDTO);
            var result = await _genericRepository.Create(entity);
            return result;
        }
    }
}
