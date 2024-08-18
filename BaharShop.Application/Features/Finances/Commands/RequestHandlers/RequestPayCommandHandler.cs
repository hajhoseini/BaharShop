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
    public class RequestPayCommandHandler : IRequestHandler<RequestPayCommand, ResultDTO<ResultRequestPayDTO>>
    {
        private readonly IGenericRepository<Pay> _payRepository;
        private readonly IGenericReader<User> _userReader;

        public RequestPayCommandHandler(IGenericRepository<Pay> payRepository, IGenericReader<User> userReader)
        {
            _payRepository = payRepository;
            _userReader = userReader;
        }

        public async Task<ResultDTO<ResultRequestPayDTO>> Handle(RequestPayCommand request, CancellationToken cancellationToken)
        {
            var user = await _userReader.GetById(request.UserId);
            Pay pay = new Pay()
            {
                Amount = request.Amount,
                Guid = Guid.NewGuid(),
                IsPay = false,
                User = user
            };

            var result = await _payRepository.Create(pay);

            return new ResultDTO<ResultRequestPayDTO>()
            {
                Data = new ResultRequestPayDTO
                {
                    Guid = pay.Guid,
                    Amount = pay.Amount,
                    Email = user.Email,
                    //MobileNumber ??
                    PayId = pay.Id
                },
                IsSuccess = true
            };
        }
    }
}
