using MediatR;
using BaharShop.Application.DTOs.Provinces;

namespace BaharShop.Application.Features.Provinces.Queries.Requests
{
    public class GetListProvincesQuery : IRequest<List<ProvinceDTO>>
    {

    }
}