using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Output;
using QYQ.Base.Common.ApiResult;
using Mapster;
using NovelPlus.Admin.Service.Domain.Entities;

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
    public async Task<ApiResult<List<NewsOutput>>> ListAsync()
    {
        var list = await _service.ListAsync(new Dictionary<string, object>());
        var output = list.Adapt<List<NewsOutput>>();
        return new ApiResult<List<NewsOutput>>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 查询单条新闻
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ApiResult<NewsOutput?>> GetAsync(long id)
    {
        var entity = await _service.GetAsync(id);
        var output = entity?.Adapt<NewsOutput>();
        return new ApiResult<NewsOutput?>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 新增新闻
    /// </summary>
    [HttpPost]
    public async Task<ApiResult<EmptyOutput>> AddAsync([FromBody] NewsOutput news)
    {
        var entity = news.Adapt<NewsEntity>();
        await _service.SaveAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 更新新闻
    /// </summary>
    [HttpPut]
    public async Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] NewsOutput news)
    {
        var entity = news.Adapt<NewsEntity>();
        await _service.UpdateAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 删除新闻
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<ApiResult<EmptyOutput>> DeleteAsync(long id)
    {
        await _service.RemoveAsync(id);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }
}
