using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Users;
using BaharShop.Application.Features.Users.Commands.Requests;
using BaharShop.Domain.Entities.UserRoles;
using BaharShop.Domain.IRepositories.Users;

namespace BaharShop.Application.Features.Users.Commands.RequestHandlers
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, ResultDTO>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public RegisterUserCommandHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<ResultDTO> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            //var entity = _mapper.Map<User>(request.RegisterUserDTO);
            //var result = await _genericRepository.Create(entity);
            //return result;

            try
            {
                var dto = request.RegisterUserDTO;

                if (string.IsNullOrWhiteSpace(dto.FullName))
                {
                    return new ResultDTO()
                    {
                        IsSuccess = false,
                        Message = "نام و نام خانوادگی را وارد نمایید"
                    };
                }

                if (string.IsNullOrWhiteSpace(dto.Email))
                {
                    return new ResultDTO()
                    {
                        IsSuccess = false,
                        Message = "پست الکترونیک را وارد نمایید"
                    };
                }
                
                if (string.IsNullOrWhiteSpace(dto.Password))
                {
                    return new ResultDTO()
                    {
                        IsSuccess = false,
                        Message = "رمز عبور را وارد نمایید"
                    };
                }
                if (dto.Password != dto.RePassword)
                {
                    return new ResultDTO()
                    {
                        IsSuccess = false,
                        Message = "رمز عبور و تکرار آن برابر نیست"
                    };
                }

                User user = new User()
                {
                    Email = dto.Email,
                    FullName = dto.FullName,
                    Password = HashPassword.Execute(dto.Password),
                };

                List<UserRole> UserRoles = new List<UserRole>();

                foreach (var item in dto.roles)
                {
                    //var roles = _context.Roles.Find(item.Id);
                    UserRoles.Add(new UserRole
                    {
                        RoleId = item.Id,
                        User = user,
                        UserId = user.Id,
                    });
                }
                user.UserRoles = UserRoles;
                user.IsActive = true;

                //_context.Users.Add(user);

                //_context.SaveChanges();
                ResultDTO register = await _userRepository.Register(user);

                var result = new ResultDTO()
                {
                    IsSuccess = register.IsSuccess
                };

                if (register.IsSuccess)
                    result.Message = "ثبت نام کاربر انجام شد";
                else
                    result.Message = register.Message;

                return result;
            }
            catch (Exception)
            {
                return new ResultDTO()
                {
                    IsSuccess = false,
                    Message = "ثبت نام انجام نشد !"
                };
            }
        }
    }
}
