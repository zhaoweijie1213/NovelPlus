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
/// 小说目录接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class BookIndexController(IBookIndexService service) : ControllerBase
{
    private readonly IBookIndexService _service = service;

    /// <summary>
    /// 查询目录列表
    /// </summary>
    [HttpGet("List")]
    public async Task<ApiResult<List<BookIndexOutput>>> ListAsync()
    {
        var list = await _service.ListAsync(new Dictionary<string, object>());
        var output = list.Adapt<List<BookIndexOutput>>();
        return new ApiResult<List<BookIndexOutput>>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 查询单个目录
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ApiResult<BookIndexOutput?>> GetAsync(long id)
    {
        var entity = await _service.GetAsync(id);
        var output = entity?.Adapt<BookIndexOutput>();
        return new ApiResult<BookIndexOutput?>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 新增目录
    /// </summary>
    [HttpPost]
    public async Task<ApiResult<EmptyOutput>> AddAsync([FromBody] BookIndexOutput index)
    {
        var entity = index.Adapt<BookIndexEntity>();
        await _service.SaveAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 更新目录
    /// </summary>
    [HttpPut]
    public async Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] BookIndexOutput index)
    {
        var entity = index.Adapt<BookIndexEntity>();
        await _service.UpdateAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 删除目录
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<ApiResult<EmptyOutput>> DeleteAsync(long id)
    {
        await _service.RemoveAsync(id);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }
}
