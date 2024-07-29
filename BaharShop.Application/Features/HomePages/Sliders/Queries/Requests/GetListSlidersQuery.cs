using MediatR;
using BaharShop.Application.DTOs.HomePages.Sliders;

namespace BaharShop.Application.Features.HomePages.Sliders.Queries.Requests
{
    public class GetListSlidersQuery : IRequest<List<SliderDTO>>
    {

    }
}