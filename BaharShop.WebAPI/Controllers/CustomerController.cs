using BaharShop.Application.Features.Customers.Commands.Requests;
using BaharShop.Application.Features.Customers.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BaharShop.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }        

        [HttpGet]
        public async Task<IActionResult> Index([FromBody] GetListCustomersQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(new { Data = result });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            GetCustomerQuery query = new GetCustomerQuery() { Id = id };
            var result = await _mediator.Send(query);
            return Ok(new { Data = result });
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCustomerCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(new { Data = result });
        }

        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] UpdateCustomerCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(new { Data = result });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteCustomerCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(new { Data = result });
        }
    }
}
