﻿using BaharShop.Application.Features.Products.Commands.Requests;
using BaharShop.Application.Features.Products.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BaharShop.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Index([FromBody] GetListProductsQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(new { Data = result });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            GetProductQuery query = new GetProductQuery() { Id = id };
            var result = await _mediator.Send(query);
            return Ok(new { Data = result });
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateProductCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(new { Data = result });
        }

        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] UpdateProductCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(new { Data = result });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteProductCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(new { Data = result });
        }
    }
}
