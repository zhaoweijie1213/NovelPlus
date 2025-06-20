using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Output;
using NovelPlus.Admin.Service.Application.Input;
using QYQ.Base.Common.ApiResult;

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
    public Task<ApiResult<List<DeptOutput>>> ListAsync()
    {
        var result = new ApiResult<List<DeptOutput>>().SetRsult(ApiResultCode.Success, new List<DeptOutput>());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 查询单个部门
    /// </summary>
    [HttpGet("{id}")]
    public Task<ApiResult<DeptOutput?>> GetAsync(long id)
    {
        var result = new ApiResult<DeptOutput?>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }

    /// <summary>
    /// 新增部门
    /// </summary>
    [HttpPost]
    public Task<ApiResult<EmptyOutput>> AddAsync([FromBody] DeptInput input)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 更新部门
    /// </summary>
    [HttpPut]
    public Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] DeptInput input)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 删除部门
    /// </summary>
    [HttpDelete("{id}")]
    public Task<ApiResult<EmptyOutput>> DeleteAsync(long id)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }
}
