using BaharShop.Application.DTOs.Categories;
using MediatR;

namespace BaharShop.Application.Features.Categories.Queries.Requests
{
    public class GetListLastLevelQuery : IRequest<List<CategoryDTO>>
    {
    }
}