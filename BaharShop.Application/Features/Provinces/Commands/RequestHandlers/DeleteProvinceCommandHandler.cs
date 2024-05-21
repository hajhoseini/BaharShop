using MediatR;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Provinces;
using BaharShop.Application.Features.Provinces.Commands.Requests;

namespace BaharShop.Application.Features.Provinces.Commands.RequestHandlers
{
    public class DeleteProvinceCommandHandler : IRequestHandler<DeleteProvinceCommand, ResultDTO>
	{
		private readonly IGenericRepository<Province> _genericRepository;

		public DeleteProvinceCommandHandler(IGenericRepository<Province> genericRepository)
		{
			_genericRepository = genericRepository;
		}

        public async Task<ResultDTO> Handle(DeleteProvinceCommand request, CancellationToken cancellationToken)
        {
            Province province = new Province { Id = request.Id };
            var result = await _genericRepository.Delete(province);
            return result;
        }
    }
}
