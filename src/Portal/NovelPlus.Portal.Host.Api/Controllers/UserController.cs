using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using NovelPlus.Portal.Service.Application.Interfaces;
using NovelPlus.Portal.Service.Application.Output;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Portal.Host.Api.Controllers;

/// <summary>
/// 用户接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class UserController(IUserService service) : ControllerBase
{
    private readonly IUserService _service = service;

    /// <summary>
    /// 用户注册
    /// </summary>
    [HttpPost("Register")]
    public Task<ApiResult<UserOutput?>> RegisterAsync()
    {
        var result = new ApiResult<UserOutput?>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }
}
