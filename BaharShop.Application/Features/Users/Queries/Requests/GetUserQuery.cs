using MediatR;
using BaharShop.Application.DTOs.Users;

namespace BaharShop.Application.Features.Users.Queries.Requests
{
    public class GetUserQuery : IRequest<UserDTO>
    {
        public int Id { get; set; }
    }
}