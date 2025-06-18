using AuthService.Service.Application;
using AuthService.Service.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.Host.Api.Controllers;

/// <summary>
/// 认证接口
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _service;

    /// <summary>
    /// 构造函数
    /// </summary>
    public AuthController(IAuthService service)
    {
        _service = service;
    }

    /// <summary>
    /// 登录
    /// </summary>
    [HttpPost("login")]
    public ActionResult<User?> Login(string userName, string password)
    {
        var user = _service.Login(userName, password);
        if (user == null) return Unauthorized();
        return Ok(user);
    }
}
