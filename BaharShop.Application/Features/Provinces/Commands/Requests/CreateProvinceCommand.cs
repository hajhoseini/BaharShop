using MediatR;
using BaharShop.Common;
using BaharShop.Application.DTOs.Provinces;

namespace BaharShop.Application.Features.Provinces.Commands.Requests
{
    public class CreateProvinceCommand : IRequest<ResultDTO>
	{
		public ProvinceDTO provinceDTO { get; set; }
	}
}
