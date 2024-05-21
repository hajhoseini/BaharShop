using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Provinces;
using BaharShop.Application.Features.Provinces.Commands.Requests;

namespace BaharShop.Application.Features.Provinces.Commands.RequestHandlers
{
    public class CreateProvinceCommandHandler : IRequestHandler<CreateProvinceCommand, ResultDTO>
	{
		private readonly IGenericRepository<Province> _genericRepository;
		private readonly IMapper _mapper;

		public CreateProvinceCommandHandler(IGenericRepository<Province> genericRepository, IMapper mapper)
		{
			_genericRepository = genericRepository;
			_mapper = mapper;
		}

        public async Task<ResultDTO> Handle(CreateProvinceCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Province>(request.provinceDTO);
            var result = await _genericRepository.Create(entity);
            return result;
        }
    }
}
