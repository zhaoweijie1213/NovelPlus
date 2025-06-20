using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Admin.Host.Api.Controllers;

/// <summary>
/// 新闻类别接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class CategoryController(ICategoryService service) : ControllerBase
{
    /// <summary>
    /// 查询类别列表
    /// </summary>
    [HttpGet("List")]
    public Task<ApiResult<List<CategoryEntity>>> ListAsync()
    {
        return Task.FromResult(ApiResult<List<CategoryEntity>>.Success(new List<CategoryEntity>()));
    }

    /// <summary>
    /// 查询单个类别
    /// </summary>
    [HttpGet("{id}")]
    public Task<ApiResult<CategoryEntity?>> GetAsync(int id)
    {
        return Task.FromResult(ApiResult<CategoryEntity?>.Success(null));
    }

    /// <summary>
    /// 新增类别
    /// </summary>
    [HttpPost]
    public Task<ApiResult> AddAsync([FromBody] CategoryEntity category)
    {
        return Task.FromResult(ApiResult.Success());
    }

    /// <summary>
    /// 更新类别
    /// </summary>
    [HttpPut]
    public Task<ApiResult> UpdateAsync([FromBody] CategoryEntity category)
    {
        return Task.FromResult(ApiResult.Success());
    }

    /// <summary>
    /// 删除类别
    /// </summary>
    [HttpDelete("{id}")]
    public Task<ApiResult> DeleteAsync(int id)
    {
        return Task.FromResult(ApiResult.Success());
    }
}
