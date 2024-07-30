using BaharShop.Application.DTOs.HomePages;
using BaharShop.Common;
using MediatR;

namespace BaharShop.Application.Features.HomePage.Commands.Requests
{
    public class CreateHomePageImageCommand : IRequest<ResultDTO>
    {
        public CreateHomePageImageDTO createHomePageImageDTO { get; set; }
    }
}