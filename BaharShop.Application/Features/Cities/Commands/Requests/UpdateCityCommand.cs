using BaharShop.Application.DTOs.Cities;
using BaharShop.Common;
using MediatR;

namespace BaharShop.Application.Features.Cities.Commands.Requests
{
    public class UpdateCityCommand : IRequest<ResultDTO>
	{
        public CityDTO cityDTO { get; set; }
    }
}
