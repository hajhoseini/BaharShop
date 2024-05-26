using BaharShop.Application.Features.Orders.Commands.Requests;
using BaharShop.Application.Features.Orders.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BaharShop.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Index([FromBody] GetListOrdersQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(new { Data = result });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            GetOrderQuery query = new GetOrderQuery() { Id = id };
            var result = await _mediator.Send(query);
            return Ok(new { Data = result });
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateOrderCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(new { Data = result });
        }

        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] UpdateOrderCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(new { Data = result });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteOrderCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(new { Data = result });
        }
    }
}
