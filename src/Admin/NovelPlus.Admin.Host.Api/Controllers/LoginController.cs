using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Output;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Admin.Host.Api.Controllers;

/// <summary>
/// 登录接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class LoginController : ControllerBase
{
    /// <summary>
    /// 用户登录
    /// </summary>
    [HttpPost]
    public Task<ApiResult<EmptyOutput>> LoginAsync()
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 用户登出
    /// </summary>
    [HttpGet("Logout")]
    public Task<ApiResult<EmptyOutput>> LogoutAsync()
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }
}
