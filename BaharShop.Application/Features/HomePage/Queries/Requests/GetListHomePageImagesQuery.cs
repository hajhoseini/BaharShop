using BaharShop.Application.DTOs.HomePages;
using BaharShop.Common;
using BaharShop.Common.Enums;
using MediatR;

namespace BaharShop.Application.Features.HomePage.Queries.Requests
{
    public class GetListHomePageImagesQuery : IRequest<ResultDTO<List<HomePageImageDTO>>>
    {
    }
}
