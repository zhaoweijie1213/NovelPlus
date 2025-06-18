using Microsoft.AspNetCore.Mvc;

namespace crawler.Service.Api.Controllers;

/// <summary>
/// 默认控制器
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{
    /// <summary>
    /// 心跳检测
    /// </summary>
    [HttpGet("ping")]
    public IActionResult Ping() => Ok("pong");
}
