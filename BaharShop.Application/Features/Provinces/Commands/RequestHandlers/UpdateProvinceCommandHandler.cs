using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Provinces;
using BaharShop.Application.Features.Provinces.Commands.Requests;

namespace BaharShop.Application.Features.Provinces.Commands.RequestHandlers
{
    public class UpdateProvinceCommandHandler : IRequestHandler<UpdateProvinceCommand, ResultDTO>
	{
		private readonly IGenericRepository<Province> _genericRepository;
		private readonly IMapper _mapper;

		public UpdateProvinceCommandHandler(IGenericRepository<Province> genericRepository, IMapper mapper)
		{
			_genericRepository = genericRepository;
			_mapper = mapper;
		}

        public async Task<ResultDTO> Handle(UpdateProvinceCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Province>(request.provinceDTO);
            var result = await _genericRepository.Update(entity);
            return result;
        }
    }
}
