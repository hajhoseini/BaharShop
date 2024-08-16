using BaharShop.Application.DTOs.Finances;
using BaharShop.Application.Features.Finances.Queries.Requests;
using BaharShop.Common;
using BaharShop.Domain.IReaders.Finances;
using MediatR;

namespace BaharShop.Application.Features.Finances.Queries.RequestHandlers
{
    public class GetListRequestPayForAdminQueryHandler : IRequestHandler<GetListRequestPayForAdminQuery, ResultDTO<List<RequestPayDTO>>>
    {
        private readonly IRequestPayReader _requestPayReader;

        public GetListRequestPayForAdminQueryHandler(IRequestPayReader requestPayReader)
        {
            _requestPayReader = requestPayReader;
        }

        public async Task<ResultDTO<List<RequestPayDTO>>> Handle(GetListRequestPayForAdminQuery request, CancellationToken cancellationToken)
        {
            var pays = await _requestPayReader.GetListForAdmin();

            var result = pays.Select(p => new RequestPayDTO
            {
                Id = p.Id,
                Amount = p.Amount,
                Authority = p.Authority,
                Guid = p.Guid,
                IsPay = p.IsPay,
                PayDate = p.PayDate,
                RefId = p.RefId,
                UserId = p.UserId,
                UserName = p.User.FullName
            }).ToList();

            return new ResultDTO<List<RequestPayDTO>>()
            {
                Data = result,
                IsSuccess = true,
            };
        }
    }
}
