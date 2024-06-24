using BaharShop.Application.DTOs.Users;
using BaharShop.Common;
using MediatR;

namespace BaharShop.Application.Features.Users.Commands.Requests
{
    public class UpdateUserCommand : IRequest<ResultDTO>
	{
        public UserDTO UserDTO { get; set; }
    }
}
