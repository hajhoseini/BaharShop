using BaharShop.Application.DTOs.Finances;
using BaharShop.Application.Features.Finances.Queries.Requests;
using BaharShop.Common;
using BaharShop.Domain.IReaders.Finances;
using MediatR;

namespace BaharShop.Application.Features.Finances.Queries.RequestHandlers
{
    public class GetRequestPayQueryHandler : IRequestHandler<GetRequestPayQuery, ResultDTO<RequestPayDTO>>
    {
        private readonly IRequestPayReader _requestPayReader;

        public GetRequestPayQueryHandler(IRequestPayReader requestPayReader)
        {
            _requestPayReader = requestPayReader;
        }

        public async Task<ResultDTO<RequestPayDTO>> Handle(GetRequestPayQuery request, CancellationToken cancellationToken)
        {
            var requestPayEntity = await _requestPayReader.GetByGuid(request.Guid);

            if (requestPayEntity != null)
            {
                return new ResultDTO<RequestPayDTO>()
                {
                    Data = new RequestPayDTO()
                    {
                        Id = requestPayEntity.Id,
                        Amount = requestPayEntity.Amount,
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
