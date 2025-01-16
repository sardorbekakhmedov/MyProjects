using Payments.Orders.Application.Models.Authentication;

namespace Payments.Orders.Application.Abstractions;

public interface IAuthService
{
    Task<UserResponse> Register(UserRegisterDto userRegisterModel);
    Task<UserResponse> Login(UserLoginDto userLoginDto);
}