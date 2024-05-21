using BaharShop.Application.DTOs.Categories;
using BaharShop.Common;
using MediatR;

namespace BaharShop.Application.Features.Categories.Commands.Requests
{
    public class UpdateCategoryCommand : IRequest<ResultDTO>
	{
        public CategoryDTO categoryDTO { get; set; }
    }
}
