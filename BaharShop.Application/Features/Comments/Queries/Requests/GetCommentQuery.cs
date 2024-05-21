using MediatR;
using BaharShop.Application.DTOs.Comments;

namespace BaharShop.Application.Features.Comments.Queries.Requests
{
    public class GetCommentQuery : IRequest<CommentDTO>
    {
        public int Id { get; set; }
    }
}