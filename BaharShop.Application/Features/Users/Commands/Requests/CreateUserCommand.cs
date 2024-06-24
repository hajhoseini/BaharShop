using MediatR;
using BaharShop.Common;
using BaharShop.Application.DTOs.Users;

namespace BaharShop.Application.Features.Users.Commands.Requests
{
    public class CreateUserCommand : IRequest<ResultDTO>
	{
		public UserDTO userDTO { get; set; }
	}
}
