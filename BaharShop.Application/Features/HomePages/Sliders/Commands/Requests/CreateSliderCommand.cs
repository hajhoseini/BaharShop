using MediatR;
using BaharShop.Common;
using Microsoft.AspNetCore.Http;

namespace BaharShop.Application.Features.HomePages.Sliders.Commands.Requests
{
    public class CreateSliderCommand : IRequest<ResultDTO>
	{
		public IFormFile File { get; set; }

		public string Link { get; set; }
	}
}
