using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Output;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Admin.Host.Api.Controllers;

/// <summary>
/// 会话接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class SessionController(ISessionService service) : ControllerBase
{
    private readonly ISessionService _service = service;

    /// <summary>
    /// 在线用户列表
    /// </summary>
    [HttpGet("OnlineUsers")]
    public Task<ApiResult<List<UserOutput>>> OnlineUsersAsync()
    {
        var result = new ApiResult<List<UserOutput>>().SetRsult(ApiResultCode.Success, new List<UserOutput>());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 强制下线
    /// </summary>
    [HttpPost("ForceLogout/{sessionId}")]
    public Task<ApiResult<EmptyOutput>> ForceLogoutAsync(string sessionId)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }
}
