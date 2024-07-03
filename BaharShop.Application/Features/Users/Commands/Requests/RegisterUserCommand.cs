using BaharShop.Application.DTOs.Users;
using BaharShop.Common;
using MediatR;

namespace BaharShop.Application.Features.Users.Commands.Requests
{
    public class RegisterUserCommand : IRequest<ResultDTO>
    {
        public RegisterUserDTO RegisterUserDTO { get; set; }
    }
}
