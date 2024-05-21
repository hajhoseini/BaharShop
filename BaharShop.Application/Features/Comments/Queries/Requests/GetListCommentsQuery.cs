using MediatR;
using BaharShop.Application.DTOs.Comments;

namespace BaharShop.Application.Features.Comments.Queries.Requests
{
    public class GetListCommentsQuery : IRequest<List<CommentDTO>>
    {

    }
}