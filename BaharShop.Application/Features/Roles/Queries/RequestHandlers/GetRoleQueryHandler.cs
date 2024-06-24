using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Roles;
using BaharShop.Application.Features.Roles.Queries.Requests;
using BaharShop.Application.DTOs.Roles;

namespace BaharShop.Application.Features.Roles.Queries.RequestHandlers
{
    public class GetRoleQueryHandler : IRequestHandler<GetRoleQuery, RoleDTO>
    {
        private readonly IMapper _mapper;
        private readonly IRoleReader _roleReader;

        public GetRoleQueryHandler(IMapper mapper, IRoleReader roleReader)
        {
            _mapper = mapper;
            _roleReader = roleReader;
        }

        public async Task<RoleDTO> Handle(GetRoleQuery request, CancellationToken cancellationToken)
        {
            var roleEntity = await _roleReader.GetById(request.Id);
            return _mapper.Map<RoleDTO>(roleEntity);
        }
    }
}
