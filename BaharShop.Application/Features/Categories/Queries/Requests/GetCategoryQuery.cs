using MediatR;
using BaharShop.Application.DTOs.Categories;

namespace BaharShop.Application.Features.Categories.Queries.Requests
{
    public class GetCategoryQuery : IRequest<CategoryDTO>
    {
        public int Id { get; set; }
    }
}