using MediatR;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Cities;
using BaharShop.Application.Features.Cities.Commands.Requests;

namespace BaharShop.Application.Features.Cities.Commands.RequestHandlers
{
    public class DeleteCityCommandHandler : IRequestHandler<DeleteCityCommand, ResultDTO>
	{
		private readonly IGenericRepository<City> _genericRepository;

		public DeleteCityCommandHandler(IGenericRepository<City> genericRepository)
		{
			_genericRepository = genericRepository;
		}

        public async Task<ResultDTO> Handle(DeleteCityCommand request, CancellationToken cancellationToken)
        {
            City city = new City { Id = request.Id };
            var result = await _genericRepository.Delete(city);
            return result;
        }
    }
}
