using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using NovelPlus.Portal.Service.Application.Interfaces;
using NovelPlus.Portal.Service.Application.Output;
using Mapster;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Portal.Host.Api.Controllers;

/// <summary>
/// 新闻接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class NewsController(INewsService service) : ControllerBase
{
    private readonly INewsService _service = service;

    /// <summary>
    /// 查询首页新闻
    /// </summary>
    [HttpGet("ListIndexNews")]
    public async Task<ApiResult<List<NewsOutput>>> ListIndexNewsAsync()
    {
        var list = await _service.ListIndexNewsAsync();
        var output = list.Adapt<List<NewsOutput>>();
        return new ApiResult<List<NewsOutput>>().SetRsult(ApiResultCode.Success, output);
    }
}
