using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Comments;
using BaharShop.Application.DTOs.Comments;
using BaharShop.Application.Features.Comments.Queries.Requests;

namespace BaharShop.Application.Features.Comments.Queries.RequestHandlers
{
    public class GetCommentQueryHandler : IRequestHandler<GetCommentQuery, CommentDTO>
    {
        private readonly IMapper _mapper;
        private readonly ICommentReader _commentReader;

        public GetCommentQueryHandler(IMapper mapper, ICommentReader CommentReader)
        {
            _mapper = mapper;
            _commentReader = CommentReader;
        }

        public async Task<CommentDTO> Handle(GetCommentQuery request, CancellationToken cancellationToken)
        {
            var commentEntity = await _commentReader.GetById(request.Id);
            return _mapper.Map<CommentDTO>(commentEntity);
        }
    }
}
