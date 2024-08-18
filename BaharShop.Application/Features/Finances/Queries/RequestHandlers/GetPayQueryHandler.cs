using BaharShop.Application.DTOs.Finances;
using BaharShop.Application.Features.Finances.Queries.Requests;
using BaharShop.Common;
using BaharShop.Domain.IReaders.Finances;
using MediatR;

namespace BaharShop.Application.Features.Finances.Queries.RequestHandlers
{
    public class GetPayQueryHandler : IRequestHandler<GetPayQuery, ResultDTO<PayDTO>>
    {
        private readonly IPayReader _payReader;

        public GetPayQueryHandler(IPayReader payReader)
        {
            _payReader = payReader;
        }

        public async Task<ResultDTO<PayDTO>> Handle(GetPayQuery request, CancellationToken cancellationToken)
        {
            var payEntity = await _payReader.GetByGuid(request.Guid);

            if (payEntity != null)
            {
                return new ResultDTO<PayDTO>()
                {
                    Data = new PayDTO()
                    {
                        Id = payEntity.Id,
                        Amount = payEntity.Amount,
                    },
                    IsSuccess = true
                };
            }
            else
            {
                throw new Exception("request pay not found");
            }
        }
    }
}
