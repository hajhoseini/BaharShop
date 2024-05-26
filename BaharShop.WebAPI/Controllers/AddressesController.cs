using BaharShop.Application.Features.Addresses.Commands.Requests;
using BaharShop.Application.Features.Addresses.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BaharShop.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AddressController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Index([FromBody] GetListAddressesQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(new { Data = result });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            GetAddressQuery query = new GetAddressQuery() { Id = id };
            var result = await _mediator.Send(query);
            return Ok(new { Data = result });
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateAddressCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(new { Data = result });
        }

        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] UpdateAddressCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(new { Data = result });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteAddressCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(new { Data = result });
        }
    }
}
