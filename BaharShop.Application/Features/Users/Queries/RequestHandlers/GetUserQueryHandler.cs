using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Users;
using BaharShop.Application.Features.Users.Queries.Requests;
using BaharShop.Application.DTOs.Users;

namespace BaharShop.Application.Features.Users.Queries.RequestHandlers
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUserReader _userReader;

        public GetUserQueryHandler(IMapper mapper, IUserReader userReader)
        {
            _mapper = mapper;
            _userReader = userReader;
        }

        public async Task<UserDTO> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var UserEntity = await _userReader.GetById(request.Id);
            return _mapper.Map<UserDTO>(UserEntity);
        }
    }
}
