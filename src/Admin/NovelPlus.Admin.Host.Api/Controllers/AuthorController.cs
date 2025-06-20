using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Admin.Host.Api.Controllers;

/// <summary>
/// 作者接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class AuthorController(IAuthorService service) : ControllerBase
{
    /// <summary>
    /// 查询作者列表
    /// </summary>
    [HttpGet("List")]
    public Task<ApiResult<List<AuthorEntity>>> ListAsync()
    {
        return Task.FromResult(ApiResult<List<AuthorEntity>>.Success(new List<AuthorEntity>()));
    }

    /// <summary>
    /// 查询单个作者
    /// </summary>
    [HttpGet("{id}")]
    public Task<ApiResult<AuthorEntity?>> GetAsync(long id)
    {
        return Task.FromResult(ApiResult<AuthorEntity?>.Success(null));
    }

    /// <summary>
    /// 新增作者
    /// </summary>
    [HttpPost]
    public Task<ApiResult> AddAsync([FromBody] AuthorEntity author)
    {
        return Task.FromResult(ApiResult.Success());
    }

    /// <summary>
    /// 更新作者
    /// </summary>
    [HttpPut]
    public Task<ApiResult> UpdateAsync([FromBody] AuthorEntity author)
    {
        return Task.FromResult(ApiResult.Success());
    }

    /// <summary>
    /// 删除作者
    /// </summary>
    [HttpDelete("{id}")]
    public Task<ApiResult> DeleteAsync(long id)
    {
        return Task.FromResult(ApiResult.Success());
    }
}
