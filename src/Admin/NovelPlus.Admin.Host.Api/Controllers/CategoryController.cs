using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Input;
using NovelPlus.Admin.Service.Application.Output;
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
    private readonly ICategoryService _service = service;

    private static CategoryOutput ToOutput(CategoryEntity entity)
    {
        return new CategoryOutput
        {
            Id = entity.Id,
            Name = entity.Name,
            Sort = entity.Sort,
            CreateTime = entity.CreateTime,
            UpdateTime = entity.UpdateTime
        };
    }
    /// <summary>
    /// 查询类别列表
    /// </summary>
    [HttpGet("List")]
    public async Task<ApiResult<List<CategoryOutput>>> ListAsync()
    {
        var list = await _service.ListAsync(new Dictionary<string, object>());
        var output = list.ConvertAll(ToOutput);
        return new ApiResult<List<CategoryOutput>>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 查询单个类别
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ApiResult<CategoryOutput?>> GetAsync(int id)
    {
        var entity = await _service.GetAsync(id);
        var output = entity == null ? null : ToOutput(entity);
        return new ApiResult<CategoryOutput?>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 新增类别
    /// </summary>
    [HttpPost]
    public async Task<ApiResult<EmptyOutput>> AddAsync([FromBody] CategoryInput category)
    {
        var entity = new CategoryEntity
        {
            Name = category.Name,
            Sort = category.Sort
        };
        await _service.SaveAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 更新类别
    /// </summary>
    [HttpPut]
    public async Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] CategoryInput category)
    {
        var entity = new CategoryEntity
        {
            Id = category.Id,
            Name = category.Name,
            Sort = category.Sort
        };
        await _service.UpdateAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 删除类别
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<ApiResult<EmptyOutput>> DeleteAsync(int id)
    {
        await _service.RemoveAsync(id);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }
}
