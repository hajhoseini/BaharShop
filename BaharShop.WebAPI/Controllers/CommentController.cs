using BaharShop.Application.Features.Comments.Commands.Requests;
using BaharShop.Application.Features.Comments.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BaharShop.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CommentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Index([FromBody] GetListCommentsQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(new { Data = result });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            GetCommentQuery query = new GetCommentQuery() { Id = id };
            var result = await _mediator.Send(query);
            return Ok(new { Data = result });
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCommentCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(new { Data = result });
        }

        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] UpdateCommentCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(new { Data = result });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteCommentCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(new { Data = result });
        }
    }
}
