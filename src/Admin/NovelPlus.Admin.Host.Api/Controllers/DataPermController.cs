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
/// 数据权限接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class DataPermController(IDataPermService service) : ControllerBase
{
    private readonly IDataPermService _service = service;

    /// <summary>
    /// 查询数据权限列表
    /// </summary>
    [HttpGet("List")]
    public async Task<ApiResult<List<DataPermOutput>>> ListAsync()
    {
        var list = await _service.ListAsync(new Dictionary<string, object>());
        var output = list.Adapt<List<DataPermOutput>>();
        return new ApiResult<List<DataPermOutput>>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 查询单个数据权限
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ApiResult<DataPermOutput?>> GetAsync(long id)
    {
        var entity = await _service.GetAsync(id);
        var output = entity?.Adapt<DataPermOutput>();
        return new ApiResult<DataPermOutput?>().SetRsult(ApiResultCode.Success, output);
    }

    /// <summary>
    /// 新增数据权限
    /// </summary>
    [HttpPost]
    public async Task<ApiResult<EmptyOutput>> AddAsync([FromBody] DataPermInput input)
    {
        var entity = input.Adapt<SysDataPermEntity>();
        await _service.SaveAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 更新数据权限
    /// </summary>
    [HttpPut]
    public async Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] DataPermInput input)
    {
        var entity = input.Adapt<SysDataPermEntity>();
        await _service.UpdateAsync(entity);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }

    /// <summary>
    /// 删除数据权限
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<ApiResult<EmptyOutput>> DeleteAsync(long id)
    {
        await _service.RemoveAsync(id);
        return new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
    }
}
