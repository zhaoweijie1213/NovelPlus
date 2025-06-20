using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Output;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Admin.Host.Api.Controllers;

/// <summary>
/// 小说评论接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class BookCommentController(IBookCommentService service) : ControllerBase
{
    private readonly IBookCommentService _service = service;

    /// <summary>
    /// 查询评论列表
    /// </summary>
    [HttpGet("List")]
    public Task<ApiResult<List<BookCommentOutput>>> ListAsync()
    {
        var result = new ApiResult<List<BookCommentOutput>>().SetRsult(ApiResultCode.Success, new List<BookCommentOutput>());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 查询单个评论
    /// </summary>
    [HttpGet("{id}")]
    public Task<ApiResult<BookCommentOutput?>> GetAsync(long id)
    {
        var result = new ApiResult<BookCommentOutput?>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }

    /// <summary>
    /// 新增评论
    /// </summary>
    [HttpPost]
    public Task<ApiResult<EmptyOutput>> AddAsync([FromBody] BookCommentOutput comment)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 更新评论
    /// </summary>
    [HttpPut]
    public Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] BookCommentOutput comment)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 删除评论
    /// </summary>
    [HttpDelete("{id}")]
    public Task<ApiResult<EmptyOutput>> DeleteAsync(long id)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }
}
