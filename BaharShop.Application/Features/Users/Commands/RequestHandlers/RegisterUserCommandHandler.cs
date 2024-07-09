using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.Entities.Users;
using BaharShop.Application.Features.Users.Commands.Requests;
using BaharShop.Domain.Entities.UserRoles;
using BaharShop.Domain.IRepositories.Users;
using System.Text.RegularExpressions;
using BaharShop.Application.DTOs.Users;

namespace BaharShop.Application.Features.Users.Commands.RequestHandlers
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, ResultDTO<UserDTO>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public RegisterUserCommandHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<ResultDTO<UserDTO>> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dto = request.RegisterUserDTO;

                if (string.IsNullOrWhiteSpace(dto.FullName))
                {
                    return new ResultDTO<UserDTO>()
                    {
                        Data = null,
                        IsSuccess = false,
                        Message = "نام و نام خانوادگی را وارد نمایید"
                    };
                }

                if (string.IsNullOrWhiteSpace(dto.Email))
                {
                    return new ResultDTO<UserDTO>()
                    {
                        Data = null,
                        IsSuccess = false,
                        Message = "پست الکترونیک را وارد نمایید"
                    };
                }

                if (string.IsNullOrWhiteSpace(dto.Password))
                {
                    return new ResultDTO<UserDTO>()
                    {
                        Data = null,
                        IsSuccess = false,
                        Message = "رمز عبور را وارد نمایید"
                    };
                }

                if (dto.Password.Length < 8)
                {
                    return new ResultDTO<UserDTO>
                    {
                        Data = null,
                        IsSuccess = false,
                        Message = "رمز عبور باید حداقل 8 کاراکتر باشد"
                    };
                }

                if (dto.Password != dto.RePassword)
                {
                    return new ResultDTO<UserDTO>()
                    {
                        Data = null,
                        IsSuccess = false,
                        Message = "رمز عبور و تکرار آن برابر نیست"
                    };
                }

                string emailRegex = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[A-Z0-9.-]+\.[A-Z]{2,}$";

                var match = Regex.Match(dto.Email, emailRegex, RegexOptions.IgnoreCase);
                if (!match.Success)
                {
                    return new ResultDTO<UserDTO>()
                    {
                        Data = null,
                        IsSuccess = false,
                        Message = "پست الکترونیک خود را به درستی وارد نمایید"
                    };
                }

                var passwordHasher = new PasswordHasher();
                var hashedPassword = passwordHasher.HashPassword(dto.Password);

                User user = new User()
                {
                    Email = dto.Email,
                    FullName = dto.FullName,
                    Password = hashedPassword,
                };

                List<UserRole> UserRoles = new List<UserRole>();

                foreach (var item in dto.roles)
                {
                    UserRoles.Add(new UserRole
                    {
                        RoleId = item.Id,
                        User = user,
                        UserId = user.Id,
                    });
                }
                user.UserRoles = UserRoles;
                user.IsActive = true;

                ResultDTO<User> register = await _userRepository.Register(user);

                var result = new ResultDTO<UserDTO>()
                {
                    Data = _mapper.Map<UserDTO>(register.Data),
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
                return new ResultDTO<UserDTO>()
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "ثبت نام انجام نشد !"
                };
            }
        }
    }
}