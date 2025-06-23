using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using NovelPlus.Portal.Service.Application.Interfaces;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Portal.Host.Api.Controllers;

/// <summary>
/// 缓存接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class CacheController(ICacheService service) : ControllerBase
{
    private readonly ICacheService _service = service;

    /// <summary>
    /// 刷新缓存
    /// </summary>
    [HttpGet("Refresh/{pass}/{type}")]
    public Task<ApiResult<bool>> RefreshCacheAsync(string pass, byte type)
    {
        _service.Del(pass + type);
        return Task.FromResult(new ApiResult<bool>().SetRsult(ApiResultCode.Success, true));
    }
}
