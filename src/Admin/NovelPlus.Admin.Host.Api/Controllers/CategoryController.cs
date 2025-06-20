using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Input;
using NovelPlus.Admin.Service.Application.Output;
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
    private readonly ICategoryService _service = service;
    /// <summary>
    /// 查询类别列表
    /// </summary>
    [HttpGet("List")]
    public Task<ApiResult<List<CategoryOutput>>> ListAsync()
    {
        var result = new ApiResult<List<CategoryOutput>>().SetRsult(ApiResultCode.Success, new List<CategoryOutput>());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 查询单个类别
    /// </summary>
    [HttpGet("{id}")]
    public Task<ApiResult<CategoryOutput?>> GetAsync(int id)
    {
        var result = new ApiResult<CategoryOutput?>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }

    /// <summary>
    /// 新增类别
    /// </summary>
    [HttpPost]
    public Task<ApiResult<EmptyOutput>> AddAsync([FromBody] CategoryInput category)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 更新类别
    /// </summary>
    [HttpPut]
    public Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] CategoryInput category)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 删除类别
    /// </summary>
    [HttpDelete("{id}")]
    public Task<ApiResult<EmptyOutput>> DeleteAsync(int id)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }
}
