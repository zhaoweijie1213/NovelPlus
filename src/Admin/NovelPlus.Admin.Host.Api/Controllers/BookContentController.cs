using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Output;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Admin.Host.Api.Controllers;

/// <summary>
/// 小说内容接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class BookContentController(IBookContentService service) : ControllerBase
{
    private readonly IBookContentService _service = service;

    /// <summary>
    /// 查询内容列表
    /// </summary>
    [HttpGet("List")]
    public Task<ApiResult<List<BookContentOutput>>> ListAsync()
    {
        var result = new ApiResult<List<BookContentOutput>>().SetRsult(ApiResultCode.Success, new List<BookContentOutput>());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 查询单个内容
    /// </summary>
    [HttpGet("{id}")]
    public Task<ApiResult<BookContentOutput?>> GetAsync(long id)
    {
        var result = new ApiResult<BookContentOutput?>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }

    /// <summary>
    /// 新增内容
    /// </summary>
    [HttpPost]
    public Task<ApiResult<EmptyOutput>> AddAsync([FromBody] BookContentOutput content)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 更新内容
    /// </summary>
    [HttpPut]
    public Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] BookContentOutput content)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 删除内容
    /// </summary>
    [HttpDelete("{id}")]
    public Task<ApiResult<EmptyOutput>> DeleteAsync(long id)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }
}
