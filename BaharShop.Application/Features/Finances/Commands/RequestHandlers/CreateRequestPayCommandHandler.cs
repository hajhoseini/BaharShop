using BaharShop.Application.DTOs.Finances;
using BaharShop.Application.Features.Finances.Commands.Requests;
using BaharShop.Common;
using BaharShop.Domain.Entities.Finances;
using BaharShop.Domain.Entities.Users;
using BaharShop.Domain.IReaders;
using BaharShop.Domain.IRepositories;
using MediatR;

namespace BaharShop.Application.Features.Finances.Commands.RequestHandlers
{
    public class CreateRequestPayCommandHandler : IRequestHandler<CreateRequestPayCommand, ResultDTO<ResultRequestPayDTO>>
    {
        private readonly IGenericRepository<RequestPay> _requestPayRepository;
        private readonly IGenericReader<User> _userReader;
        //private readonly IMapper _mapper;

        public CreateRequestPayCommandHandler(IGenericRepository<RequestPay> requestPayRepository, IGenericReader<User> userReader)
        {
            _requestPayRepository = requestPayRepository;
            _userReader = userReader;
        }

        public async Task<ResultDTO<ResultRequestPayDTO>> Handle(CreateRequestPayCommand request, CancellationToken cancellationToken)
        {
            var user = await _userReader.GetById(request.UserId);
            RequestPay requestPay = new RequestPay()
            {
                Amount = request.Amount,
                Guid = Guid.NewGuid(),
                IsPay = false,
                User = user
            };

            var result = await _requestPayRepository.Create(requestPay);

            return new ResultDTO<ResultRequestPayDTO>()
            {
                Data = new ResultRequestPayDTO
                {
                    Guid = requestPay.Guid,
                    Amount = requestPay.Amount,
                    Email = user.Email,
                    //MobileNumber ??
                    RequestPayId = requestPay.Id
                },
                IsSuccess = true
            };
        }
    }
}
