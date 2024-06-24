using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.UserRoles;
using BaharShop.Application.Features.UserRoles.Queries.Requests;
using BaharShop.Application.DTOs.UserRoles;

namespace BaharShop.Application.Features.UserRoles.Queries.RequestHandlers
{
    public class GetUserRoleQueryHandler : IRequestHandler<GetUserRoleQuery, UserRoleDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUserRoleReader _userRoleReader;

        public GetUserRoleQueryHandler(IMapper mapper, IUserRoleReader userRoleReader)
        {
            _mapper = mapper;
            _userRoleReader = userRoleReader;
        }

        public async Task<UserRoleDTO> Handle(GetUserRoleQuery request, CancellationToken cancellationToken)
        {
            var UserRoleEntity = await _userRoleReader.GetById(request.Id);
            return _mapper.Map<UserRoleDTO>(UserRoleEntity);
        }
    }
}
