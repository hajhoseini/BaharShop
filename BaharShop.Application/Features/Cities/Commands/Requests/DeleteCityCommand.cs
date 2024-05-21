using MediatR;
using BaharShop.Common;

namespace BaharShop.Application.Features.Cities.Commands.Requests
{
    public class DeleteCityCommand : IRequest<ResultDTO>
	{
		public int Id { get; set; }
	}
}
