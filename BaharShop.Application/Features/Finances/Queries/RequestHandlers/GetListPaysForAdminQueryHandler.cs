using BaharShop.Application.DTOs.Finances;
using BaharShop.Application.Features.Finances.Queries.Requests;
using BaharShop.Common;
using BaharShop.Domain.IReaders.Finances;
using MediatR;

namespace BaharShop.Application.Features.Finances.Queries.RequestHandlers
{
    public class GetListPaysForAdminQueryHandler : IRequestHandler<GetListPaysForAdminQuery, ResultDTO<List<PayDTO>>>
    {
        private readonly IPayReader _payReader;

        public GetListPaysForAdminQueryHandler(IPayReader payReader)
        {
            _payReader = payReader;
        }

        public async Task<ResultDTO<List<PayDTO>>> Handle(GetListPaysForAdminQuery request, CancellationToken cancellationToken)
        {
            var pays = await _payReader.GetListForAdmin();

            var result = pays.Select(p => new PayDTO
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

            return new ResultDTO<List<PayDTO>>()
            {
                Data = result,
                IsSuccess = true,
            };
        }
    }
}
