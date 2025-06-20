using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Output;
using QYQ.Base.Common.ApiResult;

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
    public Task<ApiResult<List<BookIndexOutput>>> ListAsync()
    {
        var result = new ApiResult<List<BookIndexOutput>>().SetRsult(ApiResultCode.Success, new List<BookIndexOutput>());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 查询单个目录
    /// </summary>
    [HttpGet("{id}")]
    public Task<ApiResult<BookIndexOutput?>> GetAsync(long id)
    {
        var result = new ApiResult<BookIndexOutput?>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }

    /// <summary>
    /// 新增目录
    /// </summary>
    [HttpPost]
    public Task<ApiResult<EmptyOutput>> AddAsync([FromBody] BookIndexOutput index)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 更新目录
    /// </summary>
    [HttpPut]
    public Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] BookIndexOutput index)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 删除目录
    /// </summary>
    [HttpDelete("{id}")]
    public Task<ApiResult<EmptyOutput>> DeleteAsync(long id)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }
}
