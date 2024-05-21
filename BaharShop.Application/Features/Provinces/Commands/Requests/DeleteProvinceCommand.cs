using MediatR;
using BaharShop.Common;

namespace BaharShop.Application.Features.Provinces.Commands.Requests
{
    public class DeleteProvinceCommand : IRequest<ResultDTO>
	{
		public int Id { get; set; }
	}
}
