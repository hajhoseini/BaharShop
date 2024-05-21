using MediatR;
using BaharShop.Common;
using BaharShop.Application.DTOs.Categories;

namespace BaharShop.Application.Features.Categories.Commands.Requests
{
    public class CreateCategoryCommand : IRequest<ResultDTO>
	{
		public CategoryDTO categoryDTO { get; set; }
	}
}
