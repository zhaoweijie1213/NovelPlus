using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Output;
using QYQ.Base.Common.ApiResult;
using Mapster;

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
    public async Task<ApiResult<List<UserOutput>>> OnlineUsersAsync()
    {
        var list = await _service.ListOnlineUsersAsync();
        var output = list.Adapt<List<UserOutput>>();
        return new ApiResult<List<UserOutput>>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 强制下线
    /// </summary>
    [HttpPost("ForceLogout/{sessionId}")]
    public async Task<ApiResult<EmptyOutput>> ForceLogoutAsync(string sessionId)
    {
        await _service.ForceLogoutAsync(sessionId);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }
}
