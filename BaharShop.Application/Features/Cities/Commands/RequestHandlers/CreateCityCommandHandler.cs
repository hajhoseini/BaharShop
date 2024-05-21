using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Cities;
using BaharShop.Application.Features.Cities.Commands.Requests;

namespace BaharShop.Application.Features.Cities.Commands.RequestHandlers
{
    public class CreateCityCommandHandler : IRequestHandler<CreateCityCommand, ResultDTO>
	{
		private readonly IGenericRepository<City> _genericRepository;
		private readonly IMapper _mapper;

		public CreateCityCommandHandler(IGenericRepository<City> genericRepository, IMapper mapper)
		{
			_genericRepository = genericRepository;
			_mapper = mapper;
		}

        public async Task<ResultDTO> Handle(CreateCityCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<City>(request.cityDTO);
            var result = await _genericRepository.Create(entity);
            return result;
        }
    }
}
