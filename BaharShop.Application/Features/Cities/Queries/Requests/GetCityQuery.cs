using MediatR;
using BaharShop.Application.DTOs.Cities;

namespace BaharShop.Application.Features.Cities.Queries.Requests
{
    public class GetCityQuery : IRequest<CityDTO>
    {
        public int Id { get; set; }
    }
}