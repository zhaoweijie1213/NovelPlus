using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Admin.Host.Api.Controllers;

/// <summary>
/// 小说接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class BookController(IBookService service) : ControllerBase
{
    /// <summary>
    /// 查询小说列表
    /// </summary>
    [HttpGet("List")]
    public Task<ApiResult<List<BookEntity>>> ListAsync()
    {
        return Task.FromResult(ApiResult<List<BookEntity>>.Success(new List<BookEntity>()));
    }

    /// <summary>
    /// 查询单本小说
    /// </summary>
    [HttpGet("{id}")]
    public Task<ApiResult<BookEntity?>> GetAsync(long id)
    {
        return Task.FromResult(ApiResult<BookEntity?>.Success(null));
    }

    /// <summary>
    /// 新增小说
    /// </summary>
    [HttpPost]
    public Task<ApiResult> AddAsync([FromBody] BookEntity book)
    {
        return Task.FromResult(ApiResult.Success());
    }

    /// <summary>
    /// 更新小说
    /// </summary>
    [HttpPut]
    public Task<ApiResult> UpdateAsync([FromBody] BookEntity book)
    {
        return Task.FromResult(ApiResult.Success());
    }

    /// <summary>
    /// 删除小说
    /// </summary>
    [HttpDelete("{id}")]
    public Task<ApiResult> DeleteAsync(long id)
    {
        return Task.FromResult(ApiResult.Success());
    }
}
