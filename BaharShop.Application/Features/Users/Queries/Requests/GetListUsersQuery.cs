using MediatR;
using BaharShop.Application.DTOs.Users;

namespace BaharShop.Application.Features.Users.Queries.Requests
{
    public class GetListUsersQuery : IRequest<List<UserDTO>>
    {

    }
}