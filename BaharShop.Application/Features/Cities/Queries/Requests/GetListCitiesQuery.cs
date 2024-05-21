using MediatR;
using BaharShop.Application.DTOs.Cities;

namespace BaharShop.Application.Features.Cities.Queries.Requests
{
    public class GetListCitiesQuery : IRequest<List<CityDTO>>
    {

    }
}