using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using NovelPlus.Portal.Service.Application.Interfaces;
using NovelPlus.Portal.Service.Application.Output;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Portal.Host.Api.Controllers;

/// <summary>
/// 友情链接接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class FriendLinkController(IFriendLinkService service) : ControllerBase
{
    private readonly IFriendLinkService _service = service;

    /// <summary>
    /// 查询首页友情链接
    /// </summary>
    [HttpGet("ListIndexLink")]
    public Task<ApiResult<List<FriendLinkOutput>>> ListIndexLinkAsync()
    {
        var result = new ApiResult<List<FriendLinkOutput>>().SetRsult(ApiResultCode.Success, new List<FriendLinkOutput>());
        return Task.FromResult(result);
    }
}
