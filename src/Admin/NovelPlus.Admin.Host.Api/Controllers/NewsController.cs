using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Output;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Admin.Host.Api.Controllers;

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
    /// 查询新闻列表
    /// </summary>
    [HttpGet("List")]
    public Task<ApiResult<List<NewsOutput>>> ListAsync()
    {
        var result = new ApiResult<List<NewsOutput>>().SetRsult(ApiResultCode.Success, new List<NewsOutput>());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 查询单条新闻
    /// </summary>
    [HttpGet("{id}")]
    public Task<ApiResult<NewsOutput?>> GetAsync(long id)
    {
        var result = new ApiResult<NewsOutput?>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }

    /// <summary>
    /// 新增新闻
    /// </summary>
    [HttpPost]
    public Task<ApiResult<EmptyOutput>> AddAsync([FromBody] NewsOutput news)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 更新新闻
    /// </summary>
    [HttpPut]
    public Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] NewsOutput news)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 删除新闻
    /// </summary>
    [HttpDelete("{id}")]
    public Task<ApiResult<EmptyOutput>> DeleteAsync(long id)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }
}
