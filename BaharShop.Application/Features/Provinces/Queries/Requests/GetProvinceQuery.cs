using MediatR;
using BaharShop.Application.DTOs.Provinces;

namespace BaharShop.Application.Features.Provinces.Queries.Requests
{
    public class GetProvinceQuery : IRequest<ProvinceDTO>
    {
        public int Id { get; set; }
    }
}