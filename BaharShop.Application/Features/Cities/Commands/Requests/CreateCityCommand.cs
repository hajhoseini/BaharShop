using MediatR;
using BaharShop.Common;
using BaharShop.Application.DTOs.Cities;

namespace BaharShop.Application.Features.Cities.Commands.Requests
{
    public class CreateCityCommand : IRequest<ResultDTO>
	{
		public CityDTO cityDTO { get; set; }
	}
}
