using MediatR;
using BaharShop.Common;
using BaharShop.Application.DTOs.HomePages.Sliders;

namespace BaharShop.Application.Features.HomePages.Sliders.Commands.Requests
{
    public class CreateSliderCommand : IRequest<ResultDTO>
	{
		public SliderDTO SliderDTO { get; set; }
	}
}
