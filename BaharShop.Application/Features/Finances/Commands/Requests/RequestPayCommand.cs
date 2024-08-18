using BaharShop.Application.DTOs.Finances;
using BaharShop.Common;
using MediatR;

namespace BaharShop.Application.Features.Finances.Commands.Requests
{
    public class RequestPayCommand : IRequest<ResultDTO<ResultRequestPayDTO>>
    {
        public int UserId { get; set; }

        public decimal Amount { get; set; }
    }
}