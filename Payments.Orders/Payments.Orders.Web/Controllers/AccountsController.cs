using Microsoft.AspNetCore.Mvc;
using Payments.Orders.Application.Abstractions;
using Payments.Orders.Application.Models.Authentication;

namespace Payments.Orders.Web.Controllers;

[Route("accounts")]
public class AccountsController(IAuthService authService) : ApiBaseController
{
    [HttpPost("login")]
    public async Task<IActionResult> Login(UserLoginDto userLoginDto)
    {
        var result = await authService.Login(userLoginDto);
        
        return Ok(result);
    } 
    
    [HttpPost("register")]
    public async Task<IActionResult> Register(UserRegisterDto userRegisterDto)
    {
        var result = await authService.Register(userRegisterDto);
        
        return Ok(result);
    }
}