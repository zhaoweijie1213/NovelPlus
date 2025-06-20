using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Output;
using NovelPlus.Admin.Service.Application.Input;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Admin.Host.Api.Controllers;

/// <summary>
/// 角色数据权限接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class RoleDataPermController(IRoleDataPermService service) : ControllerBase
{
    private readonly IRoleDataPermService _service = service;

    /// <summary>
    /// 查询列表
    /// </summary>
    [HttpGet("List")]
    public Task<ApiResult<List<RoleDataPermOutput>>> ListAsync()
    {
        var result = new ApiResult<List<RoleDataPermOutput>>().SetRsult(ApiResultCode.Success, new List<RoleDataPermOutput>());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 查询单个记录
    /// </summary>
    [HttpGet("{id}")]
    public Task<ApiResult<RoleDataPermOutput?>> GetAsync(long id)
    {
        var result = new ApiResult<RoleDataPermOutput?>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }

    /// <summary>
    /// 新增记录
    /// </summary>
    [HttpPost]
    public Task<ApiResult<EmptyOutput>> AddAsync([FromBody] RoleDataPermInput input)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 更新记录
    /// </summary>
    [HttpPut]
    public Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] RoleDataPermInput input)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 删除记录
    /// </summary>
    [HttpDelete("{id}")]
    public Task<ApiResult<EmptyOutput>> DeleteAsync(long id)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }
}
