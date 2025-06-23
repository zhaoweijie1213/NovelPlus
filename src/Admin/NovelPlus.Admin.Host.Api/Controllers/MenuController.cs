using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Output;
using NovelPlus.Admin.Service.Application.Input;
using QYQ.Base.Common.ApiResult;
using Mapster;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Host.Api.Controllers;

/// <summary>
/// 菜单接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class MenuController(IMenuService service) : ControllerBase
{
    private readonly IMenuService _service = service;

    /// <summary>
    /// 查询菜单列表
    /// </summary>
    [HttpGet("List")]
    public async Task<ApiResult<List<MenuOutput>>> ListAsync()
    {
        var list = await _service.ListAsync(new Dictionary<string, object>());
        var output = list.Adapt<List<MenuOutput>>();
        return new ApiResult<List<MenuOutput>>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 查询单个菜单
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ApiResult<MenuOutput?>> GetAsync(long id)
    {
        var entity = await _service.GetAsync(id);
        var output = entity?.Adapt<MenuOutput>();
        return new ApiResult<MenuOutput?>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 新增菜单
    /// </summary>
    [HttpPost]
    public async Task<ApiResult<EmptyOutput>> AddAsync([FromBody] MenuInput input)
    {
        var entity = input.Adapt<SysMenuEntity>();
        await _service.SaveAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 更新菜单
    /// </summary>
    [HttpPut]
    public async Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] MenuInput input)
    {
        var entity = input.Adapt<SysMenuEntity>();
        await _service.UpdateAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 删除菜单
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<ApiResult<EmptyOutput>> DeleteAsync(long id)
    {
        await _service.RemoveAsync(id);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }
}
