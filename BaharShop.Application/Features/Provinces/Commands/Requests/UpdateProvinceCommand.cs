using BaharShop.Application.DTOs.Provinces;
using BaharShop.Common;
using MediatR;

namespace BaharShop.Application.Features.Provinces.Commands.Requests
{
    public class UpdateProvinceCommand : IRequest<ResultDTO>
	{
        public ProvinceDTO provinceDTO { get; set; }
    }
}
