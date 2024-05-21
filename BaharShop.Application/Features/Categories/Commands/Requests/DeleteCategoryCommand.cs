using MediatR;
using BaharShop.Common;

namespace BaharShop.Application.Features.Categories.Commands.Requests
{
    public class DeleteCategoryCommand : IRequest<ResultDTO>
	{
		public int Id { get; set; }
	}
}
