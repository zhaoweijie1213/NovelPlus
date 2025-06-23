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
/// 部门接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class DeptController(IDeptService service) : ControllerBase
{
    private readonly IDeptService _service = service;

    /// <summary>
    /// 查询部门列表
    /// </summary>
    [HttpGet("List")]
    public async Task<ApiResult<List<DeptOutput>>> ListAsync()
    {
        var list = await _service.ListAsync(new Dictionary<string, object>());
        var output = list.Adapt<List<DeptOutput>>();
        return new ApiResult<List<DeptOutput>>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 查询单个部门
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ApiResult<DeptOutput?>> GetAsync(long id)
    {
        var entity = await _service.GetAsync(id);
        var output = entity?.Adapt<DeptOutput>();
        return new ApiResult<DeptOutput?>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 新增部门
    /// </summary>
    [HttpPost]
    public async Task<ApiResult<EmptyOutput>> AddAsync([FromBody] DeptInput input)
    {
        var entity = input.Adapt<SysDeptEntity>();
        await _service.SaveAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 更新部门
    /// </summary>
    [HttpPut]
    public async Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] DeptInput input)
    {
        var entity = input.Adapt<SysDeptEntity>();
        await _service.UpdateAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 删除部门
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<ApiResult<EmptyOutput>> DeleteAsync(long id)
    {
        await _service.RemoveAsync(id);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }
}
