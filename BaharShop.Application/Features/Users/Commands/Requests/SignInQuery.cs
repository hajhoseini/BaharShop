using BaharShop.Application.DTOs.Users;
using BaharShop.Common;
using MediatR;

namespace BaharShop.Application.Features.Users.Queries.Requests
{
    public class SignInQuery : IRequest<ResultDTO<UserDTO>>
    {
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}