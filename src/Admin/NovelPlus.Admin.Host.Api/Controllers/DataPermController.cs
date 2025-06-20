using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Asp.Versioning;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Application.Output;
using NovelPlus.Admin.Service.Application.Input;
using QYQ.Base.Common.ApiResult;

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
    public Task<ApiResult<List<DataPermOutput>>> ListAsync()
    {
        var result = new ApiResult<List<DataPermOutput>>().SetRsult(ApiResultCode.Success, new List<DataPermOutput>());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 查询单个数据权限
    /// </summary>
    [HttpGet("{id}")]
    public Task<ApiResult<DataPermOutput?>> GetAsync(long id)
    {
        var result = new ApiResult<DataPermOutput?>().SetRsult(ApiResultCode.Success, null);
        return Task.FromResult(result);
    }

    /// <summary>
    /// 新增数据权限
    /// </summary>
    [HttpPost]
    public Task<ApiResult<EmptyOutput>> AddAsync([FromBody] DataPermInput input)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 更新数据权限
    /// </summary>
    [HttpPut]
    public Task<ApiResult<EmptyOutput>> UpdateAsync([FromBody] DataPermInput input)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }

    /// <summary>
    /// 删除数据权限
    /// </summary>
    [HttpDelete("{id}")]
    public Task<ApiResult<EmptyOutput>> DeleteAsync(long id)
    {
        var result = new ApiResult<EmptyOutput>().SetRsult(ApiResultCode.Success, new EmptyOutput());
        return Task.FromResult(result);
    }
}
